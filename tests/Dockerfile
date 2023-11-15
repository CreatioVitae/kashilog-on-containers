FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS testBuilder

# テストプロジェクトでCI用のappsettingsを読み込むための環境変数
ENV TEST_ENVIRONMENT Ci

RUN apt-get update && apt-get install -y --no-install-recommends wait-for-it \
    && apt-get clean \
    && rm -rf /var/lib/apt/lists/* 

# 依存関係の復元のためにcsprojファイルをdocker上にコピーする
COPY "./WebApi.Kashilog.Tests/WebApi.Kashilog.Tests.csproj" "./tests/WebApi.Kashilog.Tests.csproj"

# 依存関係の復元
RUN dotnet restore "./tests/WebApi.Kashilog.Tests.csproj"

# テストプロジェクトのソース+entrypoint.shをdocker上にコピーする
COPY . .

# 実行権限の付与
RUN chmod +x ./entrypoint.sh