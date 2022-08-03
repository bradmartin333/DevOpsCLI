# DevOpsCLI
Follow these steps to get to automating Azure DevOps

## Generate a new token
1. Go to Azure DevOps and click user settings icon next to personal icon in top right
2. Click on the "Personal Access Tokens" option

![a](https://user-images.githubusercontent.com/19335151/182711926-98041f6f-3cf8-4a22-a266-fafcbde90df1.png)

3. Click "New Token" and match the options (Adjust date as necessary)

![b](https://user-images.githubusercontent.com/19335151/182711955-4cf1d3be-4cb0-4155-bc73-7da83be57997.png)

4. Copy the token as instructed and save it somewhere locally

## Install Azure CLI
1. [Download Azure CLI installer from this link](https://aka.ms/installazurecliwindows)
2. Run downloaded file and install as admin
3. Open powershell and execute `az` to verify install
4. Login to Azure DevOps CLI and install the necessary extension
    - `az devops login`
    - `Y`
5. Paste the new token with the right mouse button, then click enter
    - In the case of an error - try closing the shell and starting again from #3
7. Set the organization
    - `az devops configure -d organization=https://dev.azure.com/paratadevops/`
8. Test showing info for an example work-item
    - `az boards work-item show --id 27856`
9. If a long return string is printed, then Azure CLI is all set up!

## Automation
- Download and use the [included .exe](https://github.com/bradmartin333/DevOpsCLI/raw/master/DevOpsCLI/bin/Release/DevOpsCLI.exe) for the automation available currently in this repo
- Clone the repo and tinker as needed with the aid of the Azure CLI docs online
