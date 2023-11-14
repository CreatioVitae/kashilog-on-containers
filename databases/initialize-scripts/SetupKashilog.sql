use KashiLogDB

BEGIN
    BEGIN TRY

        BEGIN TRANSACTION

        SET IDENTITY_INSERT enterprise.CmnCompany ON
        INSERT INTO enterprise.CmnCompany(CompanyId,CompanyName,ZipCode,Country,City,Address,TelephoneNumber,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(1,N'江崎グリコ株式会社',N'555-8502',N'日本',N'大阪府大阪市',N'西淀川区歌島四丁目6番5号',N'0120-917-111',N'2017/05/13',N'2017/05/13',1);
        INSERT INTO enterprise.CmnCompany(CompanyId,CompanyName,ZipCode,Country,City,Address,TelephoneNumber,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(2,N'森永製菓株式会社',N'108-8403',N'日本',N'東京都港区',N'芝5-33-1',N'0120-560-162',N'2017/05/13',N'2017/05/13',1);
        INSERT INTO enterprise.CmnCompany(CompanyId,CompanyName,ZipCode,Country,City,Address,TelephoneNumber,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(3,N'株式会社 明治',N'104-8306',N'日本',N'東京都中央区',N'京橋二丁目2番1号 京橋エドグラン',N' 0120-370-369',N'2017/05/13',N'2017/05/13',1);
        INSERT INTO enterprise.CmnCompany(CompanyId,CompanyName,ZipCode,Country,City,Address,TelephoneNumber,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(4,N'株式会社ロッテ',N'160-0023',N'日本',N'東京都新宿区',N'西新宿3-20-1',N'0120-302-300',N'2017/05/13',N'2017/05/13',1);
        INSERT INTO enterprise.CmnCompany(CompanyId,CompanyName,ZipCode,Country,City,Address,TelephoneNumber,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(5,N'カルビー株式会社',N'100-0005',N'日本',N'東京都千代田区',N'丸の内1-8-3 丸の内トラストタワー本館22階',N'0120-55-8570',N'2017/05/13',N'2017/05/13',1);
        INSERT INTO enterprise.CmnCompany(CompanyId,CompanyName,ZipCode,Country,City,Address,TelephoneNumber,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(6,N'株式会社湖池屋',N'175-0094',N'日本',N'東京都板橋区',N'成増五丁目9番7号',N'0120-941-751',N'2017/05/13',N'2017/05/13',1);
        INSERT INTO enterprise.CmnCompany(CompanyId,CompanyName,ZipCode,Country,City,Address,TelephoneNumber,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(7,N'ヤマザキビスケット株式会社',N'163-0540',N'日本',N'東京都新宿区',N'西新宿1-26-2　新宿野村ビル40F',N'0120-945-522',N'2017/05/13',N'2017/05/13',1);
        INSERT INTO enterprise.CmnCompany(CompanyId,CompanyName,ZipCode,Country,City,Address,TelephoneNumber,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(8,N'亀田製菓株式会社',N'950-0198',N'日本',N'新潟県新潟市',N'江南区亀田工業団地3丁目1番1号',N'0120-24-8880',N'2017/05/13',N'2017/05/13',1);
        INSERT INTO enterprise.CmnCompany(CompanyId,CompanyName,ZipCode,Country,City,Address,TelephoneNumber,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(9,N'越後製菓株式会社',N'940-8622',N'日本',N'新潟県長岡市',N'呉服町1丁目4番地5',N'0120-917-651',N'2017/05/13',N'2017/05/13',1);
        INSERT INTO enterprise.CmnCompany(CompanyId,CompanyName,ZipCode,Country,City,Address,TelephoneNumber,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(10,N'三幸製菓株式会社',N'950-3195',N'日本',N'新潟県新潟市',N'北区新崎2丁目6番1号',N'0120-99-7343',N'2017/05/13',N'2017/05/13',1);
        INSERT INTO enterprise.CmnCompany(CompanyId,CompanyName,ZipCode,Country,City,Address,TelephoneNumber,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(11,N'カンロ株式会社',N'165-8775',N'日本',N'東京都中野区',N'新井2丁目10番11号',N'0120-88-0422',N'2017/05/13',N'2017/05/13',1);
        INSERT INTO enterprise.CmnCompany(CompanyId,CompanyName,ZipCode,Country,City,Address,TelephoneNumber,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(12,N'ノーベル製菓株式会社',N'544-0004',N'日本',N'大阪府大阪市',N'生野区巽北4丁目10番2号',N'0120-47-0141',N'2017/05/13',N'2017/05/13',1);
        INSERT INTO enterprise.CmnCompany(CompanyId,CompanyName,ZipCode,Country,City,Address,TelephoneNumber,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(13,N'ライオン菓子株式会社',N'112-0002',N'日本',N'東京都文京区',N'小石川 1-28-1',N'03-5840-8961',N'2017/05/13',N'2017/05/13',1);
        INSERT INTO enterprise.CmnCompany(CompanyId,CompanyName,ZipCode,Country,City,Address,TelephoneNumber,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(14,N'三菱食品株式会社',N'143-6556',N'日本',N'東京都大田区',N'平和島6丁目1-1 東京流通センタービル',N'03-3767-6556',N'2017/05/13',N'2017/05/13',1);

        SET IDENTITY_INSERT enterprise.CmnCompany OFF

        SET IDENTITY_INSERT kashi.CmnTaste ON
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(1,N'食欲をそそる、美味しそう',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(2,N'よだれの出そうな、美味しそうな',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(3,N'香りのよい、かんばしい',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(4,N'香りのよい、香り高い',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(5,N'香り豊かな',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(6,N'香りが良い',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(7,N'芳醇な、熟している',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(8,N'フルーティー',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(9,N'新鮮な',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(10,N'熟成された',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(11,N'発酵された',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(12,N'しょっぱい',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(13,N'不快な味、まずい、しょっぱい',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(14,N'コショウのきいた',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(15,N'魚っぽい、生臭い',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(16,N'バターいっぱいの',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(17,N'チーズ味の',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(18,N'ナッツ味の、ナッツのたくさん入った',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(19,N'油っぽい',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(20,N'苦い',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(21,N'甘い、砂糖のような',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(22,N'甘い',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(23,N'甘くしてない',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(24,N'濃厚な',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(25,N'酸っぱい',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(26,N'とても酸っぱい',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(27,N'スモーキー（燻製の味がする）',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(28,N'不快な味（匂い）がある、新鮮では無い味',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(29,N'辛い',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(30,N'熱い、辛い',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(31,N'ピリッとした',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(32,N'あっさりした',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(33,N'強い',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(34,N'マイルドな',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(35,N'ジューシー',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(36,N'乾いている、ドライ',NULL,N'2017/05/17',N'2017/05/17',1);
        INSERT INTO kashi.CmnTaste(TasteId,TasteName,TasteVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(37,N'酢（塩）漬けの',NULL,N'2017/05/17',N'2017/05/17',1);

        SET IDENTITY_INSERT kashi.CmnTaste OFF

        SET IDENTITY_INSERT kashi.CmnTexture ON
        INSERT INTO kashi.CmnTexture(TextureId,TextureName,TextureVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(1,N'かたい',null,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.CmnTexture(TextureId,TextureName,TextureVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(2,N'かみごたえのある',null,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.CmnTexture(TextureId,TextureName,TextureVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(3,N'混ざった、よく混ざった',null,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.CmnTexture(TextureId,TextureName,TextureVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(4,N'クリーミーな',null,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.CmnTexture(TextureId,TextureName,TextureVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(5,N'ふわふわした',null,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.CmnTexture(TextureId,TextureName,TextureVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(6,N'バリバリしている',null,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.CmnTexture(TextureId,TextureName,TextureVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(7,N'パリパリしている',null,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.CmnTexture(TextureId,TextureName,TextureVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(8,N'砕けやすい',null,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.CmnTexture(TextureId,TextureName,TextureVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(9,N'どろっとしている',null,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.CmnTexture(TextureId,TextureName,TextureVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(10,N'ヌルヌルしてる',null,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.CmnTexture(TextureId,TextureName,TextureVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(11,N'水けを含んだ、水分のある',null,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.CmnTexture(TextureId,TextureName,TextureVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(12,N'しけている、ふやけた、ずぶぬれの',null,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.CmnTexture(TextureId,TextureName,TextureVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(13,N'肉付きのよい、肉がたくさん入った',null,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.CmnTexture(TextureId,TextureName,TextureVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(14,N'熟した',null,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.CmnTexture(TextureId,TextureName,TextureVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(15,N'べたべたしている',null,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.CmnTexture(TextureId,TextureName,TextureVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(16,N'パン生地のようだ',null,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.CmnTexture(TextureId,TextureName,TextureVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(17,N'焼きすぎ',null,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.CmnTexture(TextureId,TextureName,TextureVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(18,N'焦げた',null,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.CmnTexture(TextureId,TextureName,TextureVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(19,N'やわらかい',null,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.CmnTexture(TextureId,TextureName,TextureVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(20,N'なめらかな',null,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.CmnTexture(TextureId,TextureName,TextureVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(21,N'ゆるい、流れやすい',null,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.CmnTexture(TextureId,TextureName,TextureVector,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(22,N'甘くてべたべたしている',null,N'2017/05/18',N'2017/05/18',1);

        SET IDENTITY_INSERT kashi.CmnTexture OFF

        declare @DataCount int
        select @DataCount = Count(*) from kashi.MstProduct
        if @DataCount > 0
	        TRUNCATE TABLE kashi.MstProduct

        SET IDENTITY_INSERT kashi.MstProduct ON
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(1,1,1,N'1966/1/1',N'2999/12/31',N'ポッキーチョコレート',1,4,3,278,9,3,N'軽快な食感に焼き上げたプレッツェルにコクのあるチョコレートをコーティング。
        ポキッとした心地よい食感のポッキーは、楽しさいっぱいの弾むおいしさです。',1,1,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(2,2,1,N'1966/1/1',N'2010/1/1',N'ポッキーチョコレート',1,4,3,108,2,3,N'軽快な食感に焼き上げたプレッツェルにコクのあるチョコレートをコーティング。
        ポキッとした心地よい食感のポッキーは、楽しさいっぱいの弾むおいしさです。',1,1,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(3,2,2,N'2010/1/1',N'2999/12/31',N'ポッキーチョコレート',1,4,3,138,2,3,N'軽快な食感に焼き上げたプレッツェルにコクのあるチョコレートをコーティング。
        ポキッとした心地よい食感のポッキーは、楽しさいっぱいの弾むおいしさです。',1,1,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(4,3,1,N'1966/1/1',N'2999/12/31',N'アーモンドクラッシュポッキー',1,4,3,138,2,3,N'クラッシュしたアーモンドを、１本にぎっしりと散りばめました。
        ミルクチョコレートと香ばしいアーモンドの旨みが織りなす絶妙なおいしさです。',1,1,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(5,4,1,N'1966/1/1',N'2999/12/31',N'ポッキー＜極細＞',1,4,3,138,2,3,N'ポッキーチョコレートの約1/2の細さに焼き上げた
        プレッツェル※2にチョコレートをコーティング。
        細く軽快なのに、チョコ感をしっかり味わえる
        〈極細〉ならではのおいしさをぜひお楽しみください。',1,1,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(6,5,1,N'1966/1/1',N'2999/12/31',N'つぶつぶいちごポッキー 〈ハートフル〉',1,4,3,138,2,3,N'いちご果肉を、プレッツェルにも練り込みました。
        最後のひとくちまでいちごを堪能できる
        いちごづくしの甘酸っぱいおいしさです。',1,1,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(7,6,1,N'2016/9/20',N'2999/12/31',N'ポッキー トリニティ〈オレンジピール〉',1,4,3,248,4,3,N'オレンジがほのかに香るプレッツェルにマイルドなミルクチョコレートをコーティング。
        さらに、ココアをまぶしたオレンジピールをトッピングしました。
        三つの風味が、口の中で上質なハーモニーを奏でます。',1,1,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(8,7,1,N'2016/9/20',N'2999/12/31',N'ポッキー トリニティ〈アーモンド〉',1,4,3,248,4,3,N'アーモンドを練り込んだパイ食感プレッツェルにアーモンドを練り込んだチョコレートをコーティング。
        さらに、ザラメ糖をトッピングしました。
        三つの風味が、口の中で上質なハーモニーを奏でます。',1,1,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(9,8,1,N'1995/5/1',N'2999/12/31',N'ココナッツポッキー',1,4,3,145,2,3,N'マイルドなチョコレートに、
        甘みを凝縮させたドライココナッツを
        トッピングしました。
        噛むほどに深まるココナッツの味わいと、
        甘い香りをどうぞお楽しみください。',1,1,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(10,9,1,N'1994/4/1',N'2999/12/31',N'トッポ',1,4,3,108,2,3,N'トッポは最後までチョコたっぷり!おいしくなったトッポを、仲間との楽しい会話のお供にどうぞ。',2,2,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(11,10,1,N'2016/12/13',N'2017/3/31',N'めざせ合格！トッパ',1,4,3,178,2,3,N'トッポで突破！頑張る受験生を応援します。東京ＦＭ【スクールオブロック!】と今年も強力タイアップ。',2,2,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(12,11,1,N'1993/1/1',N'2999/12/31',N'ダース　ミルク',1,4,4,105,12,4,N'キャラメリックでコクのある風味を活かした、濃厚な味わいのミルクチョコレート。',3,3,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(13,12,1,N'1993/1/1',N'2999/12/31',N'白いダース',1,4,4,105,12,4,N'濃厚でクリーミーなミルク感と、なめらかで後切れの良さが特長のホワイトチョコレート。',3,3,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(14,13,1,N'1975/1/1',N'2999/12/31',N'きのこの山',1,4,3,189,82,1,N'カカオの香り引き立つコクのあるチョコレートとミルクでまろやかに仕上げたチョコレート、2つを合わせたチョコレートとサクサクとしたクラッカーがおいしさのポイントです。',4,4,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(15,14,1,N'1979/1/1',N'2999/12/31',N'たけのこの里',1,4,3,163,70,1,N'カカオの香り引き立つコクのあるチョコレートとミルクでまろやかに仕上げたチョコレート、2つを合わせたチョコレートとサクサクの味わいクッキーがおいしさのポイントです。',4,4,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(16,15,1,N'2017/1/16',N'2999/12/31',N'ポテトチップスギザギザ　梅塩こんぶ味',1,1,1,104,72,1,N'京都のテキスタイルブランド「SOU ・SOU」と一緒に作った限定デザインパッケージです。
        梅の風味豊かな甘酸っぱさ & 塩味を、塩昆布の旨味と風味が包み込む、まろやかで優しく食べやすい梅味の厚切りポテトチップスです。',5,5,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(17,16,1,N'2010/11/22',N'2999/12/31',N'ポテトチップスギザギザ　味わいしお味',1,1,1,104,72,1,N'石垣の塩を使用した味わい深いしお味です。まろやかな「石垣の塩」を使用する事で、じゃがいも本来のおいしさを引き立て、丸みのある味わいに仕上がりました。',5,5,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(18,17,1,N'2013/12/1',N'2999/12/31',N'ポテトチップス　しあわせバタ～',1,1,1,134,60,1,N'4 つの素材でしあわせ気分♪
        「バター」「はちみつ」「パセリ」「マスカルポーネチーズ」の4 つの素材を合わせた、4 あわせ ( しあわせ ) バター味。4 つの味わいをベースにした甘じょっぱいおいしさです。',5,5,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(19,18,1,N'2016/8/1',N'2999/12/31',N'ポテトチップスクリスプ　うすしお',1,1,1,117,50,1,N'パリッと心地よい食感で、いつものおいしさを楽しめる',5,5,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(20,19,1,N'1992/1/1',N'2017/4/12',N'ピザポテト',1,1,1,108,63,1,N'食べ応えある厚切りカットのポテトチップスに、エメンタール & チェダーのWチーズをとろ～りトッピングです。風味豊かなチーズと、ミート・トマト・スパイスが織りなす濃厚な味わいがくせになる、満足感たっぷりのピザポテトです。',5,5,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(21,20,1,N'2014/9/1',N'2999/12/31',N'ア・ラ・ポテト　じゃがバター味',1,1,1,108,72,1,N'ア・ラ・ポテトは、1989年の発売以来、収穫の秋の訪れとともに、北海道産新じゃがのおいしさをお届けしています。ザクッとした食感と新じゃがならではのおいしさをお楽しみいただけるポテトチップスです。

        北海道産バター 100% のバターパウダーを使用してます。バターのコクとうまみがじゃがいもにぴったり、風味豊かな味わいです。',5,5,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(22,21,1,N'1993/1/1',N'2999/12/31',N'堅あげポテト　はまぐりだし味',1,1,1,108,63,1,N'噛むほどうまい ! 堅い食感でじゃがいものおいしさをじっくり楽しめるポテトチップスです。

        はまぐりのお吸い物のような、旨み感じる堅あげポテトです。噛むほどにじゅわっと感じる貝のおだしの味わいがくせになるおいしさです。',5,5,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(23,22,1,N'1975/1/1',N'2999/12/31',N'ポテトチップス　コンソメパンチ',1,1,1,108,60,1,N'お肉のうまみと野菜の甘みがギュッ ! と凝縮されたスープ。そのジューシーな香りとコクが、ポテトチップスのパリッと軽い食感にマッチしてあきのこないおいしさです。',5,5,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(24,23,1,N'1975/1/1',N'2999/12/31',N'ポテトチップス　コンソメパンチ',1,1,1,380,170,1,N'お肉のうまみと野菜の甘みがギュッ ! と凝縮されたスープ。そのジューシーな香りとコクが、ポテトチップスのパリッと軽い食感にマッチしてあきのこないおいしさです。',5,5,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(25,24,1,N'1975/1/1',N'2999/12/31',N'ポテトチップス　コンソメパンチ',1,1,1,780,500,1,N'お肉のうまみと野菜の甘みがギュッ ! と凝縮されたスープ。そのジューシーな香りとコクが、ポテトチップスのパリッと軽い食感にマッチしてあきのこないおいしさです。',5,5,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(26,25,1,N'1975/1/1',N'2999/12/31',N'ポテトチップス　のりしお',1,1,1,108,60,1,N'のりふわっ ! ふんわりのりの香り。風味豊かな青のりが、シンプルな塩味とマッチして、じゃがいものおいしさを一層引き立てます。
        さらに青のりのおいしさをいっそう引き立てるために、しっかり焙煎したごま油と唐辛子を隠し味に使用 ! 味のキレと心地よい余韻が残ります。',5,5,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(27,26,1,N'1975/1/1',N'2999/12/31',N'ポテトチップス　うすしお味',1,1,1,108,60,1,N'じゃがいものおいしさを生かした、カルビーならではのパリッと軽い食感と、塩味をきりっと効かせたメリハリのある味わいで、どんどん食べ進むおいしさです !',5,5,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(28,27,1,N'1962/1/1',N'2999/12/31',N'ポテトチップス　のり塩',1,1,1,108,60,1,N'1962年に日本人の味覚にあうポテトチップスとして「のり塩」を発売しました。のりの風味とほどよい塩味が絶妙なバランスです。',6,6,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(29,28,1,N'1962/1/1',N'2999/12/31',N'ポテトチップス　うすしお味',1,1,1,108,60,1,N'じゃがいものおいしさが引き立つうすしお味です。
        ほどよい塩味で、最後まで楽しめる味わいに仕上げました。',6,6,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(30,29,1,N'1962/1/1',N'2999/12/31',N'ポテトチップス　リッチコンソメ',1,1,1,108,60,1,N'肉と香味野菜のおいしさがギュッとつまったコンソメ味です。コクのあるリッチな味わいのおいしさです。',6,6,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(31,30,1,N'1984/9/1',N'2999/12/31',N'カラムーチョチップス ホットチリ味',1,1,1,108,55,1,N'チリ（とうがらし）を絶妙にきかせた、辛くておいしいポテトチップスです。',6,6,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(32,31,1,N'1976/1/1',N'2999/12/31',N'チップスター S （コンソメ）',1,1,1,111,50,1,N'ロングセラー・チップスターもおかげさまで愛され続けて40年。
        飽きのこない伝統のおいしさに、新しいおいしさも加わりますます人気！',7,7,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(33,32,1,N'1976/1/1',N'2999/12/31',N'ハッピーターン',2,9,5,162,22,2,N'        
        砂糖じょうゆをぽたぽた、ぽたぽた。おばあちゃんの新レシピでおしょうゆ感がUPしました。サクサクとした生地におしょうゆ感をUPした味付けは相性ぴったりです。',8,8,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(34,33,1,N'1986/1/1',N'2999/12/31',N'ぽたぽた焼',2,9,5,162,22,2,N'        
        砂糖じょうゆをぽたぽた、ぽたぽた。おばあちゃんの新レシピでおしょうゆ感がUPしました。サクサクとした生地におしょうゆ感をUPした味付けは相性ぴったりです。',8,8,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(35,34,1,N'1982/1/1',N'2999/12/31',N'こつぶっこ',2,9,5,166,124,1,N'北海道産ミルクパウダーを使った、まろやかなおいしさの揚げあられ。',8,8,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(36,35,1,N'1989/1/1',N'2999/12/31',N'海苔ピーパック',2,9,5,193,89,1,N'風味豊かな海苔巻と香ばしいピーナッツ！
        いろいろな場面で大活躍の5袋詰。',8,8,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(37,36,1,N'1967/1/1',N'2999/12/31',N'サラダうす焼',2,9,5,100,93,1,N'粗挽き仕込み製法でパリパリおいしい！かるい口どけと香ばしい風味のあっさり塩味のおせんべいです。便利な食べきりサイズ３分包入りです。',8,8,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(38,37,1,N'2000/1/1',N'2999/12/31',N'越後厚焼しょうゆ',2,9,5,216,6,2,N'直火で焼き上げ、かつおだしを効かせた醤油だれで味付けしました。',9,9,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(39,38,1,N'2000/1/1',N'2999/12/31',N'越後厚焼胡麻',2,9,5,216,6,2,N'胡麻の風味を活かし、芳醇でコクのある醤油味に仕上げました。',9,9,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(40,39,1,N'2000/1/1',N'2999/12/31',N'越後厚焼ザラメ',2,9,5,216,6,2,N'香ばしく焼き上げたおせんべいにざらめをたっぷりと絡めました。',9,9,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(41,40,1,N'2000/1/1',N'2999/12/31',N'雪の宿サラダ',2,9,5,108,24,2,N'おかげさまでロングセラー。北海道生クリーム使用の砂糖蜜のマイルドな甘さとおせんべいの塩味が絶妙なハーモニー！',10,10,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(42,41,1,N'2000/1/1',N'2999/12/31',N'香る黒豆あられ',2,9,5,216,75,1,N'香ばしい黒豆を練り込んだ食べやすいサイズのあられを、フレッシュなオリーブオイルと味わい深いハーブ＆スパイスを使用して味付けしました。BOSCOエキストラバージンオリーブオイルを使用しています。袋を開けた瞬間の、素材の香りを存分にお楽しみください。',10,10,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(43,42,1,N'2000/1/1',N'2999/12/31',N'チーズアーモンド',2,9,5,162,16,2,N'うす焼せんべいにチーズをのせ、その上にアーモンドをのせたちょっとおしゃれなお菓子です。３つの味が調和したリッチなおいしさをお楽しみください。',10,10,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(44,43,1,N'2000/1/1',N'2999/12/31',N'もりもり山のくだもの飴',1,5,6,172,180,1,N'8種類のフルーツのおいしさがたっぷり180g楽しめます。',11,11,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(45,44,1,N'2000/1/1',N'2999/12/31',N'色えんぴつキャンディ',1,5,6,162,80,1,N'かわいい色えんぴつ型の、カラフルなアソートキャンディ。',11,11,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(46,45,1,N'2000/1/1',N'2999/12/31',N'健康梅のど飴',1,5,6,192,90,1,N'着色料不使用、じっくり漬け込んだ梅はちみつのやさしくまろやかな味わいの のど飴',11,11,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(47,46,1,N'2000/1/1',N'2999/12/31',N'はちみつレモンCのど飴',1,5,6,170,90,1,N'まろやかなはちみつにレモンが爽やかに香る、おいしく癒されるのど飴です。',11,11,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(48,47,1,N'2000/1/1',N'2999/12/31',N'はちみつきんかんのど飴',1,5,6,192,110,1,N'のどにまろやかなきんかんを、はちみつにじっくり漬け込んだ、やさしい味わいののど飴です。きんかんシロップが、のどの奥までジワッと広がります。',12,12,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(49,48,1,N'2000/1/1',N'2999/12/31',N'のど黒飴',1,5,6,158,130,1,N'沖縄加工黒糖をたっぷりと使用した黒飴に、のどにまろやかな、はちみつとかりんをはじめとした18種類の野草エキスを配合した、おいしいのど飴です。',12,12,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(50,49,1,N'2000/1/1',N'2999/12/31',N'男梅',1,5,6,155,80,1,N'1粒に梅1つ分の梅果汁が入った、本格的で濃厚な梅干し本来の味わいが楽しめるキャンデーです。',12,12,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(51,50,1,N'2000/1/1',N'2999/12/31',N'きえちゃうキャンディー',1,5,6,149,100,1,N'なめると変わる色で占う、大人気のきえちゃうキャンディーです。金箔入りゴールドマンも入っています。サンフェノン配合。第26回全国菓子大博覧会(広島全菓子博）で農林水産大臣賞を受賞！今回オリジナルお弁当箱が当るキャンペーンを実施致します。',13,13,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(52,51,1,N'2000/1/1',N'2999/12/31',N'CHELSEA　バタースカッチ',1,5,6,129,10,4,N'発酵バターをじっくり煮詰めた濃厚でコクのあるおいしさのバタースカッチキャンデー。
        スマートサイズでおしゃれに持ち運べるボックスタイプ。',4,4,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(53,52,1,N'2000/1/1',N'2999/12/31',N'CHELSEA　ヨーグルトスカッチ',1,5,6,129,10,4,N'ヨーグルトのさわやかでコクのあるおいしさが楽しめるヨーグルトスカッチキャンデー。
        スマートサイズでおしゃれに持ち運べるボックスタイプ。',4,4,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(54,53,1,N'2000/1/1',N'2999/12/31',N'グリーンスムージーキャンディ',1,5,6,200,80,1,N'ファンケル青汁原料使用。
        グリーンスムージーをイメージしたキャンディ。
        食物繊維、鉄、ビタミンC、葉酸、β-カロテン入り。
        難消化性デキストリン配合。',13,14,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(55,54,1,N'2000/1/1',N'2999/12/31',N'プリッツ＜サラダ＞',1,1,2,102,2,3,N'こだわりの製法で外をパリッ、中をサクッと焼き上げました。あっさりとした塩味のプリッツ＜サラダ＞です。',1,1,N'2017/05/13',N'2017/05/13',1);
        INSERT INTO kashi.MstProduct(ProductId,ProductLineUpId,ProductRevision,ValidBeginDateTime,ValidEndDateTime,ProductName,LargeCategory,MiddleCategory,SmallCategory,UnitPrice,Amount,AmountType,Description,MakerCompanyId,PublisherCompanyId,CreatedTimeStamp,LastUpdatedTimeStamp,LastUpdatedSign) VALUES(56,55,1,N'2000/1/1',N'2999/12/31',N'トマトプリッツ',1,1,2,102,2,3,N'こだわりの製法で外をパリッ、中をサクッと焼き上げました。トマトと緑の野菜の旨みが楽しめる、カリッと香ばしいプリッツです。',1,1,N'2017/05/13',N'2017/05/13',1);

        SET IDENTITY_INSERT kashi.MstProduct OFF

        SET IDENTITY_INSERT kashi.MstProductTaste ON
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(1,1,22,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(2,2,22,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(3,3,22,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(4,4,22,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(5,4,18,4,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(6,5,22,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(7,6,22,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(8,6,25,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(9,7,22,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(10,7,20,2,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(11,8,22,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(12,8,18,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(13,9,22,4,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(14,10,22,2,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(15,11,22,2,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(16,12,22,4,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(17,13,22,5,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(18,14,22,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(19,15,22,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(20,16,12,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(21,16,25,4,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(22,17,12,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(23,18,16,2,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(24,19,12,2,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(25,20,17,4,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(26,21,16,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(27,22,12,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(28,23,12,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(29,24,12,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(30,25,12,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(31,26,12,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(32,27,12,2,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(33,28,12,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(34,29,12,2,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(35,30,12,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(36,31,29,2,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(37,32,12,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(38,33,22,2,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(39,33,12,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(40,34,12,2,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(41,34,22,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(42,35,12,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(43,36,12,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(44,36,4,2,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(45,36,18,2,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(46,37,12,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(47,38,12,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(48,39,12,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(49,40,21,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(50,40,12,2,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(51,41,21,4,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(52,41,12,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(53,42,12,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(54,42,18,1,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(55,42,6,5,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(56,43,17,4,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(57,43,18,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(58,44,8,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(59,45,8,2,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(60,46,22,2,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(61,47,25,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(62,48,25,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(63,49,25,4,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(64,50,26,2,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(65,51,8,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(66,52,16,5,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(67,53,22,4,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(68,54,8,4,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(69,55,12,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTaste(ProductTasteId,ProductId,TasteId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(70,56,12,3,N'2017/05/18',N'2017/05/18',1);

        SET IDENTITY_INSERT kashi.MstProductTaste OFF

        SET IDENTITY_INSERT kashi.MstProductTexture ON
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(1,1,1,2,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(2,2,1,2,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(3,3,1,2,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(4,4,1,2,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(5,5,1,1,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(6,6,1,2,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(7,7,1,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(8,8,1,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(9,9,1,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(10,10,1,4,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(11,11,1,4,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(12,12,1,6,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(13,13,1,6,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(14,14,1,4,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(15,15,1,1,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(16,15,8,2,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(17,16,7,4,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(18,17,7,4,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(19,18,7,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(20,19,7,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(21,20,4,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(22,20,7,4,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(23,21,7,4,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(24,22,7,5,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(25,23,7,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(26,24,7,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(27,25,7,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(28,26,7,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(29,27,7,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(30,28,7,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(31,29,7,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(32,30,7,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(33,31,7,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(34,32,7,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(35,33,6,5,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(36,33,1,2,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(37,34,6,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(38,34,1,1,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(39,34,22,6,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(40,35,1,6,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(41,35,6,6,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(42,36,6,8,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(43,36,2,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(44,37,1,1,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(45,37,7,8,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(46,38,1,8,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(47,38,6,7,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(48,38,17,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(49,39,1,8,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(50,39,6,7,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(51,39,17,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(52,40,1,9,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(53,40,6,7,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(54,40,17,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(55,41,6,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(56,41,22,4,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(57,41,1,1,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(58,42,1,5,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(59,42,6,5,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(60,43,1,1,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(61,43,2,5,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(62,43,7,4,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(63,44,1,10,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(64,45,1,10,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(65,46,1,10,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(66,47,1,10,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(67,48,1,10,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(68,49,1,10,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(69,50,1,10,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(70,51,1,10,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(71,52,1,10,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(72,53,1,10,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(73,54,1,10,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(74,55,1,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(75,55,17,1,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(76,56,1,3,N'2017/05/18',N'2017/05/18',1);
        INSERT INTO kashi.MstProductTexture(ProductTextureId,ProductId,TextureId,Value,CreatedDateTime,LastUpdatedDateTime,LastUpdatedSign) VALUES(77,56,17,1,N'2017/05/18',N'2017/05/18',1);

        SET IDENTITY_INSERT kashi.MstProductTexture OFF

        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION

        PRINT   'ErrorNumber:' + CONVERT(nvarchar, ERROR_NUMBER())  + NCHAR(13) + NCHAR(10) + 
                'ErrorSeverity:' + CONVERT(nvarchar, ERROR_SEVERITY())  + NCHAR(13) + NCHAR(10) + 
                'ErrorState:' + CONVERT(nvarchar, ERROR_STATE())  + NCHAR(13) + NCHAR(10) + 
                --'ErrorProcedure:' + CONVERT(nvarchar, ERROR_PROCEDURE())  + NCHAR(13) + NCHAR(10) + 
                'ErrorLine:' + CONVERT(nvarchar, ERROR_LINE())  + NCHAR(13) + NCHAR(10) + 
                'ErrorMessage:'+ CONVERT(nvarchar(1000), ERROR_MESSAGE())
                ;
    END CATCH
END