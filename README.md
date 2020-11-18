# Alexa List Trimmer Utility

Trims saved to local drive Text.txt file exported from an Alexa List.  Trims the fluff from the list and removes the numbered entries for each list item.  It just leaves the list text.

Just export the list and save it to files, choose a share to save it to in the Alexa App.  Then on a windows machine copy the file from the share to c:\temp, then launch the console app and it will read the file, strip the text, and then launch notepad with the edited entries.

If the file is not found it will remark to the console to save text.txt to c:\temp and then run the console app.

## Getting Started
I used Visual Studio Community 2017 and .NET Framework 4 to build the console app.
### Prerequisites
```
.NET Framework 4.8
```
## Built With
* [VS Enterprise 2019](https://visualstudio.microsoft.com/downloads/) - The build software
## Versioning
We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/norton287/AlexaListTrim/tags). 
## Authors
* **John Norton** - *Initial work* - [norton287](https://github.com/norton287)
See also the list of [contributors](https://github.com/norton287/AlexaListTrim/contributors) who participated in this project.
## License
This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details
## Acknowledgments
* Fixing what Amazon won't when exporting shopping lists from Alexa
