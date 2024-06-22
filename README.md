![Alt text](MLDas.Web/wwwroot/images/Logo.png?raw=true "Title")

## What is ML DAS?
It is a Machine Learning Data Analysis Service that targets a cybersecurity angle on file analysis but could be used for a variety of other use cases.

## Technology Stack
I am always a proponent of using the best tool for the job, so this project utilizes both C# and Rust.  C# for all of the Web Frontends, Cloud Functions, and REST Services. Meanwhile, Rust is used for the endpoint.  Utilizing both of these languages affords performance and cross-platform compatibility.

## Architecture
Initial version is only going to support a Google Cloud deployment, but it is being built modularly and with abstraction layers to support other clouds or for a local edge only deployment.

## Endpoint <-> Cloud Architecture
Below is the initial cloud architecture when an endpoint client sends or receives data:
![Alt text](Assets/Excalidraw/Endpoint_Cloud_Architecture.png?raw=true "Endpoint and Cloud Architecture")

## Endpoint Architecture
<TBD>

## Cloud Module Architecture
<TBD>

## Requirements

### Endpoint
The initial release of the Endpoint will support the following platforms:
* Windows 10+ (AMD64 and ARM64)
* Ubunutu 22.04 LTS (AMD64 and RISCV)

Future versions could include ARM64 on Ubunutu or other platforms.
