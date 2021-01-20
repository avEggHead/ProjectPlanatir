# Project Planatir
The goal is to create a collaboration tool that facilitates mob programming in Microsoft Teams.  Click the Projects tab to see the Kanban board.

# Setup for Local hosting:
1. Establish a tunnel to the locally hosted web app. 
    - If you have ngrok installed globablly, use this command from the command prompt 'ngrok http -host-header=rewrite 80'.
    - There are alternatives to ngrok, but if you want to do what I did, go here to download it https://ngrok.com/.
2. Paste the tunnel URL into all the places in the code where it says '<REPLACE THIS ...>'
    - This is required in three locations
        - websiteUrl on line 15 in Configuration.cshtml 
        - contentUrl on line 16 in Configuration.cshtml 
        - configurationUrl on line 28 in manifest.json
3. Set up a new site in IIS to host the web app.
4. Publish the web app to the new site you created in step 3.
5. Zip the contents of the CustomAppFiles folder (icon-color.png, icon-outline.png, and manifest.json).  This zip file is what Microsoft Teams will use to connect to the app.
6. Click on Apps in Teams
7. Click on Upload a custom app
8. Navigate to and select the zip file from step 5.
9. Create a new meeting, edit the meeting, and add the Project Planatir app to the meeting.
