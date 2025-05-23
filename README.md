# .NET Client for Graphlit Platform

## Overview

The Graphlit Client for .NET enables easy interaction with the Graphlit API, allowing developers to execute queries and mutations against the Graphlit service. This document outlines the setup process and provides a basic example of using the client.

## Prerequisites

Before you begin, ensure you have the following:

- .NET 6.0 or .NET 8.0 installed on your system.
- An active account on the [Graphlit Platform](https://portal.graphlit.dev) with access to the API settings dashboard.

## Building

When building the Graphlit Client, you must install the StrawberryShake tools for API code-generation.  This is only required for building the SDK.

```bash
dotnet tool install StrawberryShake.Tools --local
```

## Installation

To install the Graphlit Client, use nuget:

```bash
dotnet add package Graphlit
```

## Configuration

The Graphlit Client supports environment variables to be set for authentication and configuration:

- `GRAPHLIT_ENVIRONMENT_ID`: Your environment ID.
- `GRAPHLIT_ORGANIZATION_ID`: Your organization ID.
- `GRAPHLIT_JWT_SECRET`: Your JWT secret for signing the JWT token.

Alternately, you can pass these values with the constructor of the Graphlit client.

You can find these values in the API settings dashboard on the [Graphlit Platform](https://portal.graphlit.dev).

### Setting Environment Variables

To set these environment variables on your system, use the following commands, replacing `your_value` with the actual values from your account.

For Unix/Linux/macOS:

```bash
export GRAPHLIT_ENVIRONMENT_ID=your_environment_id_value
export GRAPHLIT_ORGANIZATION_ID=your_organization_id_value
export GRAPHLIT_JWT_SECRET=your_secret_key_value
```

For Windows Command Prompt (CMD):

```cmd
set GRAPHLIT_ENVIRONMENT_ID=your_environment_id_value
set GRAPHLIT_ORGANIZATION_ID=your_organization_id_value
set GRAPHLIT_JWT_SECRET=your_secret_key_value
```

For Windows PowerShell:

```powershell
$env:GRAPHLIT_ENVIRONMENT_ID="your_environment_id_value"
$env:GRAPHLIT_ORGANIZATION_ID="your_organization_id_value"
$env:GRAPHLIT_JWT_SECRET="your_secret_key_value"
```

## Support

Please refer to the [Graphlit API Documentation](https://docs.graphlit.dev/).

For support with the Graphlit Client, please submit a [GitHub Issue](https://github.com/graphlit/graphlit-client-dotnet/issues).  

For further support with the Graphlit Platform, please join our [Discord](https://discord.gg/ygFmfjy3Qx) community.

