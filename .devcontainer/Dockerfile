# Use the official .NET SDK image as a parent image
FROM mcr.microsoft.com/dotnet/sdk:8.0

# Install Python 3 and pip
RUN apt-get update && \
    apt-get install -y python3 python3-pip && \
    apt-get clean && \
    rm -rf /var/lib/apt/lists/*

# Add .NET tools to PATH
ENV PATH="$PATH:/root/.dotnet/tools"
