::
:: Microsoft Azure SDK for Net - Generate library code
:: Copyright (C) Microsoft Corporation. All Rights Reserved.
::

@echo off
#call %~dp0..\..\..\..\tools\generate.cmd azsadmin/resource-manager/network latest sleepyneko features/Azs.Network.Admin azure-rest-api-specs %CD%
call %~dp0..\..\..\..\tools\generate.cmd azsadmin/resource-manager/network latest sleepyneko features/Azs.Network.Admin azure-rest-api-specs %CD%
