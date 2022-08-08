param(
    [Parameter(Mandatory)]
    [int]$USER_STORY_ID
)

$story = az boards work-item show --id $USER_STORY_ID | ConvertFrom-Json

class Task
{
    [ValidateNotNullOrEmpty()][string]$Title
    [string]$Assignee
    [string]$ID

    Task([string]$title, [string]$assignee) {
        $this.Title = $title
        $this.Assignee = $assignee
    }
}

$tasks = @([Task]::new("Design Created & Reviewed", ""),
           [Task]::new("Code & Code Review", ""),
           [Task]::new("Test Plan Developed & Reviewed", ""),
           [Task]::new("Test Cases Executed & Passed", ""),
           [Task]::new("PO Acceptance", "tjenkins@parata.com"))

foreach ($task in $tasks)
{
    $newTask = az boards work-item create `
                    --title $task.Title `
                    --type "Task" `
                    --area $story.fields.'System.AreaPath' `
                    --iteration $story.fields.'System.IterationPath' `
                    --project $story.fields.'System.TeamProject' `
                    --reason "New" | ConvertFrom-Json

    if ([bool]$task.Assignee)
    {
        az boards work-item update `
            --id $newTask.id `
            --assigned-to $task.Assignee | Out-Null
    }

    az boards work-item relation add `
        --id $newTask.id `
        --relation-type "parent" `
        --target-id $story.id | Out-Null

    Write-Host $newTask.id
}