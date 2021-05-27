If you want to Debug app loccally just open project and run it.

If you want to run this project from docker image

Perequisites:
- Docker Desktop installed ( see https://docs.docker.com/docker-for-windows/install/ )

Once Docker Desktop is installed you should type fallowing commands (cmd or PowerShell) to build docker image and run it in container:

1. cd <main_project_dir>
2. dotnet publish -c Release
3. docker build -t studycases -f Dockerfile .
4. docker create --name studycases studycases
5. copy command output
6. docker run -it --rm studycases
7. paste your test case
8. you will recive result

Example: 
Please provide input or press 'Enter' to quit

 _  _  _  _  _  _  _  _
| || || || || || || ||_   |
|_||_||_||_||_||_||_| _|  |
=> 0 0 0 0 0 0 0 5 1  Invalid

 _  _  _  _  _  _  _  _  _
|_|| || || || || || ||_  _|
 _||_||_||_||_||_||_| _| _|
=> 9 0 0 0 0 0 0 5 3  Valid