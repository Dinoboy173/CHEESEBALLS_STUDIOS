@echo off

cd /d %~dp0

git add .

git status

set /P commitMessage = "Enter commit message here: "

git commit -m commitMessage%!

git pull

git push