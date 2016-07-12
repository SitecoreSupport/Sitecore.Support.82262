# Sitecore.Support.82262
When clicking the 'Lock and Edit' button a new version is not selected, if date was changed.

## Main

This repository contains Sitecore Patch #82262, which resets the `sc_date` cookie when clicking the `Lock and Edit` button. As a result, the Experience Editor selects a new version, if date was changed before in the `Experience` tab.

## Deployment

To apply the patch on either CM or CD server perform the following steps:

1. Place the `Sitecore.Support.82262.dll` assembly into the `\bin` directory.
2. Place the `z.Sitecore.Support.82262.config` file into the `\App_Config\Include` directory.

## Content 

Sitecore Patch includes the following files:

1. `\bin\Sitecore.Support.82262.dll`
2. `\App_Config\Include\z.Sitecore.Support.82262.config`

## License

This patch is licensed under the [Sitecore Corporation A/S License](LICENSE).

## Download

Downloads are available via [GitHub Releases](/releases).