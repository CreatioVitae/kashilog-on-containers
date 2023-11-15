#!/bin/bash

set -e

wait-for-it kashilog-test-sql-server:1433 -t 60 --strict -- dotnet test ./WebApi.Kashilog.Tests/WebApi.Kashilog.Tests.csproj