#!/bin/bash -e


echo haha
"C:\Program Files\Unity\Hub\Editor\2020.2.5f1\Editor\Unity.exe" \
-projectPath "C:\actions-runner\_work\Github-Action-Test\Github-Action-Test" \
-batchmode -quit \
-executeMethod Builder.BuildStart \
-buildTarget Android 