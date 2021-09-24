APP = $(or ${APP_NAME}, DotnetStdinStdout)
VERSION = $(or ${PACKAGE_VERSION}, 0.0.1)

build:
	cd ${APP} && dotnet build

test:
	cd ${APP}.Tests && dotnet test

test-watch:
	cd ${APP}.Tests && dotnet watch test

