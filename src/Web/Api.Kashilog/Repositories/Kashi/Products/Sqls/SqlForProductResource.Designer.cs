﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Api.Kashilog.Repositories.Kashi.Products.Sqls {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SqlForProductResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SqlForProductResource() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Api.Kashilog.Repositories.Kashi.Products.Sqls.SqlForProductResource", typeof(SqlForProductResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   すべてについて、現在のスレッドの CurrentUICulture プロパティをオーバーライドします
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Select
        ///	ProductId				AS ProductId,
        ///	ProductRevision			AS ProductRevision,	
        ///	ValidBeginDateTime		AS ValidBeginDateTime,
        ///	ValidEndDateTime		AS ValidEndDateTime,		
        ///	ProductName				AS ProductName,			
        ///	LargeCategory			AS LargeCategory,		
        ///	MiddleCategory			AS MiddleCategory,
        ///	SmallCategory			AS SmallCategory,			
        ///	UnitPrice				AS UnitPrice,
        ///	Amount					AS Amount,
        ///	AmountType				AS AmountType,
        ///	Description				AS Description,
        ///	MakerCompanyId			AS MakerCompanyId,
        ///	PublisherCompanyId		AS PublisherCompany [残りの文字列は切り詰められました]&quot;; に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string FindAllProduct {
            get {
                return ResourceManager.GetString("FindAllProduct", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Select
        ///	ProductId				AS ProductId,
        ///	ProductRevision			AS ProductRevision,	
        ///	ValidBeginDateTime		AS ValidBeginDateTime,
        ///	ValidEndDateTime		AS ValidEndDateTime,		
        ///	ProductName				AS ProductName,			
        ///	LargeCategory			AS LargeCategory,		
        ///	MiddleCategory			AS MiddleCategory,
        ///	SmallCategory			AS SmallCategory,			
        ///	UnitPrice				AS UnitPrice,
        ///	Amount					AS Amount,
        ///	AmountType				AS AmountType,
        ///	Description				AS Description,
        ///	MakerCompanyId			AS MakerCompanyId,
        ///	PublisherCompanyId		AS PublisherCompany [残りの文字列は切り詰められました]&quot;; に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string FindProductById {
            get {
                return ResourceManager.GetString("FindProductById", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Select
        ///	ProductTaste.ProductId	AS ProductId,
        ///	ProductTaste.TasteId	AS TasteId,
        ///	Taste.TasteName			AS TasteName,
        ///	ProductTaste.Value		AS Value
        ///From
        ///	kashi.MstProductTaste ProductTaste
        ///Inner Join
        ///	Kashi.CmnTaste Taste
        ///On
        ///	ProductTaste.TasteId = Taste.TasteId
        ///Where
        ///	ProductTaste.ProductId = @ProductId に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string FindProductTasteByProductId {
            get {
                return ResourceManager.GetString("FindProductTasteByProductId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Select
        ///	ProductTaste.ProductId	AS ProductId,
        ///	ProductTaste.TasteId	AS TasteId,
        ///	Taste.TasteName			AS TasteName,
        ///	ProductTaste.Value		AS Value
        ///From
        ///	kashi.MstProductTaste ProductTaste
        ///Inner Join
        ///	Kashi.CmnTaste Taste
        ///On
        ///	ProductTaste.TasteId = Taste.TasteId
        ///Where
        ///	ProductTaste.ProductId In @ProductIds に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string FindProductTasteInProductIds {
            get {
                return ResourceManager.GetString("FindProductTasteInProductIds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Select
        ///	ProductTexture.ProductId	AS ProductId,
        ///	ProductTexture.TextureId	AS TextureId,
        ///	Texture.TextureName			AS TextureName,
        ///	ProductTexture.Value		AS Value
        ///From
        ///	kashi.MstProductTexture ProductTexture
        ///Inner Join
        ///	Kashi.CmnTexture Texture
        ///On
        ///	ProductTexture.TextureId = Texture.TextureId
        ///Where
        ///	ProductTexture.ProductId = @ProductId に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string FindProductTextureByProductId {
            get {
                return ResourceManager.GetString("FindProductTextureByProductId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Select
        ///	ProductTexture.ProductId	AS ProductId,
        ///	ProductTexture.TextureId	AS TextureId,
        ///	Texture.TextureName			AS TextureName,
        ///	ProductTexture.Value		AS Value
        ///From
        ///	kashi.MstProductTexture ProductTexture
        ///Inner Join
        ///	Kashi.CmnTexture Texture
        ///On
        ///	ProductTexture.TextureId = Texture.TextureId
        ///Where
        ///	ProductTexture.ProductId In @ProductIds に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string FindProductTextureInProductIds {
            get {
                return ResourceManager.GetString("FindProductTextureInProductIds", resourceCulture);
            }
        }
    }
}
