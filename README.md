# MSBT-Merger
A simple program for merging MSBT entries. It can also view MSBT files but nothing more.

## MSBT
MSBT is a text/localization file structure used by Nintendo in first-party games. The format has remained unchanged over the years. If you want to learn more, refer to [this webpage](http://mk8.tockdom.com/wiki/MSBT_(File_Format)).

## Support
- Wii, 3DS, Wii U, and Switch games
- non-Latin characters

![](https://github.com/theawesomecoder61/MSBT-Merger/blob/main/screen.png?raw=true)
(files from Super Smash Bros. Ultimate)

## Usage
1. Select both `.msbt` files by selecting File and clicking on the respective option
2. You can review the entries by clicking on an entry in lists under "MSBT 1" and "MSBT 2".
  - If you want to merge specific entries, click the checkbox on those. Be sure to check the "Merge Only Selected" option.
  - Otherwise, all matching entries will be merged.
  - Additionally, if you want nonexistent entries to be created, there is an option for that.
3. Select options on the "Result MSBT" side, then click on one of the "Copy \_ onto \_" buttons.
4. You will be prompted to select where the program will save the resulting `.msbt`.

## Building
1. Clone the repo
2. Open the `.sln` in Visual Studio and select "Release" from the Debug dropdown
3. Build

# Credits
- IcySon55 (his [MSBT Editor](https://github.com/IcySon55/3DLandMSBTeditor) is great for creating & editing MSBT files)
