# Important Documentation Notice
The documentation process was finalized the week of Novemeber 10, 2024. The docuemntation will be updated more over this week. 
At the moment the API documentation for the pre-alpha has begun, but the API properties need more descriptions and the manual needs added.
The manual button at the top will do nothing at the moment when clicked so don't worry if you click it and it does nothing. It is not a bug.
The manual is being implemented either the week of Novemeber 10th, or the following week. We are focusing on the API documentation and landing page first.

[Example WIP API Documentation Page](https://shatter-fantasy.github.io/SF-UI-Elements/api/SFEditor.UIElements.Utilities.MouseRectDragManipulator.html)

# Important Pre Alpha Notice!!!
This package is in pre alpha release, so not even alpha one is out.
Some folders have a couple scripts that were added, but not fully implemented yet, just to keep track of what is needed for Alpha 1 full release.
See the very bottom section on this page to see what all is planned to change or be added for the Alpha 1 release.

## Introduction
Introduction section is a WIP for the read me on the repo page. Alpha 1 release will have the initial introduction finished.

The SF UI Elements package is designed to help make working with Unity's UI Toolkit a bit easier through a set of utility methods and custom visual elements.
Starting in Alpha 2 there will be pre-made controls, fields, base classes to help set up window based editor tools, a set core uss styles seperated into different style sheets.

## Types Of Style Sheet
---
### Component Style Sheet
The component style sheet will have the styles for pre-made compoents.

## Alpha One Release Plan
---
### Visual Element Style Extentions
We plan to add a few more style extensions before Alpha 1 release. There are a few already in there, but we want to do more. 
For example we have a method chain system for the extensions methods to be able to quickly and easily set styles in C#. 
We have a set all method for margins and borders, but we would like to change them to take in the same parameters as the CSS type for them. 
Basically allow passing in on margin value to set all, two margin value where the first passed in one sets the top/bottom and the second one sets left/right,
than you can pass in all four values to set all of them how you want and passing in an empty value will ignore that one side allowing to set only three of them.

## Pushed To Alpha 2
Some of the below might have had files added to the repo already and needs to be moved to a branch for that feature. 
This started before we had a workflow to integrate branches, release note generation, and more using GitHub actions.
So some files need cleaned up and moved out of the master branch. 
---
### Editor Window Base
The Editor Window Base class will be fully redone not that we have a better idea of ways to do custom binding to custom controls and now that we know
how we want to set up asset loading for editor based visual elements.

### Asset Database Folder
The Asset Database folder will be removed and added back in later.
We decided to move the Asset Database asset tool to Alpha 2. This is to get Alpha 1 out sooner and because Jonathan Westfall (SF Deverloper)
figured out how to hook into Unity Package Manager API. The API hook allows us to auto download dependencies from GitHub automatically, so we can link for example.
SF UI Elements Alpha 1 release to SF Utilities Alpha 1 release. The SF Utilities already had some nice ways utility tools for Unity's Asset Database API.

Change log format guide
https://keepachangelog.com/en/1.1.0/

GitHub Markdown cheat sheet link
https://github.com/adam-p/markdown-here/wiki/Markdown-Cheatsheet

Unity Custom Package Documentation 
https://docs.unity3d.com/2023.2/Documentation/Manual/CustomPackages.html

Unity Third Party Notice Documentation
https://docs.unity3d.com/2023.2/Documentation/Manual/cus-legal.html
