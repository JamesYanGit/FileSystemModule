# FileSystemModule
A module that is used to read or write files
It uses the stratgy pattern, so read or write different type files can be easier.

## Interface-IFileReadControl
The interface is used to read content of files. 
It contains two methods:
 - ReadFileName: It is to read file names
 - ReadTXTFile: It is used to read TXT file content.
## Interface- IFileWriteControl
The interface is used to write to TXT files. 
It contains two methods as well:
 - WriteTXTFile is rewrite the certain TXT file content.
 - WriteTXTFileAppend is to append content to the file.
