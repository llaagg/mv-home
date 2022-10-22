# Release

After starting new project you can simply trigger release to github. This created binary dll that can be downloaded by mv client.
Relase is triggered automatically on a commit with a version tag in a special format: v0.0.0

```ps1
git tag -a v0.92.1 -m "Test relase 01" ; git push --tags
```
