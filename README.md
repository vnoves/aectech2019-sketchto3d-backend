<img src="files/icon.png" align="right" width="80" height="100" /> 

# Kanganru [](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)]

=======

<img src="files/kanganru.png" align="left" width="220" height="230" />

This project has been developed in October 2019 during the AEC Tech Hackathon organized by TTCore Studio with the following Sponsors that we thank you so much for the great resource they were able to provide. 
[Presentation](https://docs.google.com/presentation/d/1PY0RU9T0NnZnrGIihKm32UpJGw9H2y3DOEGgaJlzG2o/edit?ts=5dab4ee7#slide=id.g640068be55_0_5)

<img src="files/1.png" align="right" width="100" height="100" /> 

## Authors

* **Alberto Tono** - *San Francisco Computational Design Institute* - [SFCDI](https://www.sfcdi.org)
* **Valentine Noves** - *ENGwork* 
* **Constantina Tsiara** - *Workshop / APD* 
* **Pablo Derendinger** - *ENGwork*
* **Jeffrey Moser** - *Grimshaw*
* **Lexi Fritz** - 
* **Rachel Hartley** - *Autodesk*


* New Hire orientation and navigation
* Improving Search for new employee with Fuzzy Matching
* Undermine the limitation of the Cybersecurity in a Enterprise company

Presentation: 
https://docs.google.com/presentation/d/1uL1N66qP9okW5KsW7J7cxcwzE3m1eett8EwkJiCczc4/edit?usp=sharing


We developed a BOT called Co-Pilot that allow new hire or people who don't have access to information to send an anonimous request to the owner of those Information in order to provide this information to the new employee. They will have a co-pilot that can help them navigate company resource without affect the privacy.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system. Data Classifier: 
[data preparation](https://docs.google.com/spreadsheets/d/1GZSzPl2v0295Y-gS26Cct_d03q5E9V8QijSGZmjBVJ8/edit?usp=sharing)

### Prerequisites

Javascript, 
API Key from Yuuvis 
Azure SQL 
Schema

```
<schema xmlns="http://optimal-systems.org/ns/dmscloud/schema/v4.0/" 
        xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" 
        xsi:schemaLocation="http://optimal-systems.org/ns/dmscloud/schema/v4.0/ dmsCloud-schema.xsd">
        <propertyStringDefinition>
            <id>from</id>
            <propertyType>string</propertyType>
            <cardinality>single</cardinality>
            <required>true</required>
        </propertyStringDefinition>
        <propertyStringDefinition>
            <id>to</id>
            <propertyType>string</propertyType>
            <cardinality>multi</cardinality>
            <required>true</required>
        </propertyStringDefinition>
		<propertyStringDefinition>
            <id>subject</id>
            <propertyType>string</propertyType>
            <cardinality>single</cardinality>
            <required>true</required>
        	<defaultValue>hello</defaultValue>
        	<maxLength>20</maxLength>
	        <minLength>4</minLength>
		</propertyStringDefinition>
		<propertyDateTimeDefinition>
            <id>received</id>
            <propertyType>datetime</propertyType>
            <cardinality>single</cardinality>
            <required>true</required>
        </propertyDateTimeDefinition>
		<typeDocumentDefinition>
            <id>email</id>
            <baseId>enaio:document</baseId>
            <propertyReference>from</propertyReference>
            <propertyReference>to</propertyReference>
            <propertyReference>received</propertyReference>
			<contentStreamAllowed>required</contentStreamAllowed>
        </typeDocumentDefinition>
</schema>
```

# Architecture


<img src="files/Arc.jpg"/> 
<img src="files/team.jpg"/> 
<img src="files/Arch.jpg"/> 
<img src="files/payplan.jpg"/> 
<img src="files/solution.png"/> 

## License

[![CC0](https://licensebuttons.net/p/zero/1.0/88x31.png)](https://creativecommons.org/publicdomain/zero/1.0/)

To the extent possible under law. MIT license

