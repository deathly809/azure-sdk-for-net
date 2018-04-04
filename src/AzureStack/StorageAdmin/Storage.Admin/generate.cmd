gen::
:: Microsoft Azure SDK for Net - Generate library code
:: Copyright (C) Microsoft Corporation. All Rights Reserved.
::

@echo off
rd Generated /S /Q
call %~dp0..\..\..\..\tools\generate.cmd azsadmin/resource-manager/storage latest deathly809 AzureStack azure-rest-api-specs %CD%
move Storage\Storage.Admin\Generated .
rd Storage /S /Q