![Alt text](MLDas.Web/wwwroot/images/Logo.png?raw=true "Title")

## What is ML DAS?
It is a Machine Learning Data Analysis Service that targets a cybersecurity angle on file analysis but could be used for other use cases.

## Technology Stack
I am always a proponent of using the best tool for the job, so this project utilizes both C# and Rust.  C# is used for all Web Frontends, Cloud Functions, and REST Services, while Rust is used for the Endpoint.  Utilizing both of these languages affords performance and cross-platform compatibility.

## Architecture
The initial version will only support a Google Cloud deployment, but it is being built modularly and with abstraction layers to support other clouds or a local edge-only deployment.

## Endpoint <-> Cloud Architecture
Below is the initial cloud architecture when an endpoint client sends or receives data:
![Alt text](Assets/Excalidraw/Endpoint_Cloud_Architecture.png?raw=true "Endpoint and Cloud Architecture")

## Endpoint Architecture
To be flushed out...

## Cloud Module Architecture
To be flushed out...

## Requirements
### Server
As noted earlier, initial support will only be officially provided on Google Cloud. Abstractions will be provided, but other implementations to AWS or Azure, for example, will not be performed.

### Endpoint
The initial release of the Endpoint will support the following platforms:
* Windows 10+ (AMD64 and ARM64)
* Ubunutu 22.04 LTS (AMD64 and RISCV)

Future versions could include ARM64 on Ubunutu or other platforms.
