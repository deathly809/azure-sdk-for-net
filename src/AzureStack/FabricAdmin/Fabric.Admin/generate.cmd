::
:: Microsoft Azure SDK for Net - Generate library code
:: Copyright (C) Microsoft Corporation. All Rights Reserved.
::

@echo off
call %~dp0..\..\..\..\tools\generate.cmd azsadmin/resource-manager/fabric latest deathly809 azs.fabric.admin azure-rest-api-specs %CD%
rd Generated /S /Q
move Fabric\Fabric.Admin\Generated .
rd Fabric /S /Q