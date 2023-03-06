# Publish-Subscribe-Pattern
# Introduction

This solution will demonstrate the concept of the Publish/Subscribe pattern

## Installation

Install Visual Studio and .NET 6.
* Visual Studio Community
  * Install from https://visualstudio.microsoft.com/downloads/
* .NET6
  * Install from https://dotnet.microsoft.com/en-us/download/dotnet/6.0

## How To Run
Please build the solution or run the following command in your solution directory:
```bash
dotnet build
```
Then run the application in visual studio or use the following command:
```bash
dotnet run
```
Here is the sample output:
![Sample Output](SampleOutput20230306.jpg?raw=true "Title")

## Concerns & Decisions
* In this solution consists of one publisher class, and one subscriber interface along with three different types of subscriber classes. 
* The publisher is able to publish input data, while the subscriber can receive the data and display it in the respective type of data.
* However, currently this solution only supports three data types, including DateTime, string and integer. It could be extended for more data types by adding new subscriber classes.

## Testing
You may run the unit test in visual studio. Rebuild your solution and go to the Test > Test Explorer. Run all the test cases inside the playlist. Here is the result in my local environment. 
![Test Result](TestResult20230306.jpg?raw=true "Title")