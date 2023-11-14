FROM mcr.microsoft.com/mssql/server:2017-latest as Builder

ENV ACCEPT_EULA Y
ENV SA_PASSWORD h0geFuga
# SQLServer Edition
ENV MSSQL_PID Developer
# LoCale ID(1041=Japanese)
ENV MSSQL_LCID 1041
ENV MSSQL_MEMORY_LIMIT_MB 4096

# unzipとcurlのインストール（apt-get installするために、ダウンロード可能なパッケージのリストを更新する）
RUN apt-get update && apt-get install -y --no-install-recommends unzip curl \
    && apt-get clean \
    # sqlPackageのダウンロード
    # -Lでロケーションの指定。
    # -qでFTPに対するコマンドとして扱うようにする。（合わせることでダウンロードしてこれる）
    # -oで出力先のファイル名指定 )
    && curl -Lq https://aka.ms/sqlpackage-linux -o sqlpackage-linux-x64-latest.zip \
    && ls -alh \
    && unzip sqlpackage-linux-x64-latest.zip -d /opt/sqlpackage \
    # sqlpackageに権限付与(+xで実行権限付与)
    && chmod +x /opt/sqlpackage/sqlpackage \
    && apt-get purge -y --auto-remove unzip \
    && rm -rf /var/lib/apt/lists/*

COPY /dacpacs/KashiLogDB.dacpac /tmp/kashilogdb.dacpac

# dacpacファイルから復元
# SQLServerをバックグラウンド実行し、開始したことを確認できたことを保証するためのコマンド
RUN ( /opt/mssql/bin/sqlservr --accept-eula & ) | grep -q "Service Broker manager has started" \
    && /opt/sqlpackage/sqlpackage /a:Publish /tsn:localhost /tec:False /tdn:KashiLogDB /tu:sa /tp:h0geFuga /sf:/tmp/kashilogdb.dacpac \
    && /opt/sqlpackage/sqlpackage /a:Publish /tsn:localhost /tec:False /tdn:KashiLogDBTest /tu:sa /tp:h0geFuga /sf:/tmp/kashilogdb.dacpac \
    && rm /tmp/kashilogdb.dacpac \
    && pkill sqlservr