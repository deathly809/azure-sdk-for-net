::
:: Microsoft Azure SDK for Net - Generate library code
:: Copyright (C) Microsoft Corporation. All Rights Reserved.
::

@echo off
rd /S /Q Generated
:: call %~dp0..\..\..\..\tools\generate.cmd azsadmin/resource-manager/subscriptions latest deathly809 AzureStack azure-rest-api-specs %CD%
move Subscriptions\Subscriptions.Admin\Generated .
rd /S /Q Subscriptions
