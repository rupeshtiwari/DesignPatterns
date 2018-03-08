---
title: Template CLI
layout: post
author: rupesh
permalink: /template-cli/
source-id: 1_BjVbg9IwAZGgQxzbtt9_OD1f8kRHDPGjx32Ncufi1g
published: true
---
Template Cli 

A command line interface for creating javascript app for quick start. Please read [Javascript Composite UI document](https://goo.gl/cNnJQB) to know more about type of projects.

Table of Contents

[[TOC]]

# Prerequisites

Both the CLI and generated project have dependencies that require Node 6.9.0 or higher, together with NPM 3 or higher.

# Installation

**BEFORE YOU INSTALL: **please read the [prerequisites](#heading=h.rgnheft3nep6)

** npm i -g @scci-branding/template-cli     **

# Updating Template CLI

To update Template CLI to a new version, you must update global package.

**npm uninstall -g @scci-branding/template-cli**

**npm cache verify**

**npm install -g @scci-branding/template-cli**

# Generating and serving an Angular Ngrx App via a development server

**template-cli ngrx PROJECT-NAME -s blue -f jeans -d "blue jeans are very nice"**

**OR **

**template-cli ngrx PROJECT-NAME --service blue --feature jeans --description "blue jeans are very nice"**

Navigate to [http://localhost:4230/](http://localhost:4230/). The app will automatically reload if you change any of the source files. You can configure the default HTTP host and port used by the development server with two command-line in package.json file

![image alt text]({{ site.url }}/public/3LYW8UW5RlHCSS6rYB19rg_img_0.png)

# Generating Composite App

**template-cli composite-app COMPOSITE-APP-NAME -s branding -a my-app -d "sample composite app"**

**OR **

**template-cli composite-app COMPOSITE-APP-NAME -service branding -app my-app -description "sample composite app"**

![image alt text]({{ site.url }}/public/3LYW8UW5RlHCSS6rYB19rg_img_1.png)

# Usage

**template-cli help**

# Documentation

**template-cli docs**

# TFS Feed Location

[http://aicpa-tfs:8080/tfs/DefaultCollection/Examinations/_packaging?feed=StraszAssessmentSystems&_a=feed](http://aicpa-tfs:8080/tfs/DefaultCollection/Examinations/_packaging?feed=StraszAssessmentSystems&_a=feed)

![image alt text]({{ site.url }}/public/3LYW8UW5RlHCSS6rYB19rg_img_2.png)

# Source Code

$/ITOps/Modules/template-cli/_integration/template-cli/src

![image alt text]({{ site.url }}/public/3LYW8UW5RlHCSS6rYB19rg_img_3.png)

