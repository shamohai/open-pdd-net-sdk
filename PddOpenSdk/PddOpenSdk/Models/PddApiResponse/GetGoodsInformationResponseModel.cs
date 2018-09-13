using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class GetGoodsInformationResponseModel : PddResponseModel
    {
        /// <summary>
/// 商品详情响应对象
/// </summary>
[JsonProperty("goods_info_get_response")]
public object GoodsInfoGetResponse {get;set;}
/// <summary>
/// 商品详情对象
/// </summary>
[JsonProperty("goods_info")]
public object GoodsInfo {get;set;}
/// <summary>
/// 商品编码
/// </summary>
[JsonProperty("goods_id")]
public object GoodsId {get;set;}
/// <summary>
/// 商品序列编码
/// </summary>
[JsonProperty("goods_sn")]
public object GoodsSn {get;set;}
/// <summary>
/// 商品类型，1-普通商品，2-进口商品，3-直供，4-直邮
/// </summary>
[JsonProperty("goods_type")]
public int GoodsType {get;set;}
/// <summary>
/// 商品一级类目
/// </summary>
[JsonProperty("goods_category")]
public object GoodsCategory {get;set;}
/// <summary>
/// 叶子类目
/// </summary>
[JsonProperty("last_category")]
public object LastCategory {get;set;}
/// <summary>
/// 是否七天无理由售后，0-不支持，1-支持
/// </summary>
[JsonProperty("is_refundable")]
public int IsRefundable {get;set;}
/// <summary>
/// 承诺发货时间
/// </summary>
[JsonProperty("shipment_limit_second")]
public object ShipmentLimitSecond {get;set;}
/// <summary>
/// 商品名称
/// </summary>
[JsonProperty("goods_name")]
public object GoodsName {get;set;}
/// <summary>
/// 商品图片 url
/// </summary>
[JsonProperty("image_url")]
public object ImageUrl {get;set;}
/// <summary>
/// 商品库存
/// </summary>
[JsonProperty("goods_quantity")]
public int GoodsQuantity {get;set;}
/// <summary>
/// 商品是否上架，0-下架，1-上架；
/// </summary>
[JsonProperty("is_onsale")]
public int IsOnsale {get;set;}
/// <summary>
/// 商品是否全新，0-全新商品，1-二手商品
/// </summary>
[JsonProperty("second_hand")]
public int SecondHand {get;set;}
/// <summary>
/// 成团人数
/// </summary>
[JsonProperty("group_required_customer_num")]
public int GroupRequiredCustomerNum {get;set;}
/// <summary>
/// sku列表对象
/// </summary>
[JsonProperty("sku_list")]
public object SkuList {get;set;}
/// <summary>
/// 商品规格名称
/// </summary>
[JsonProperty("spec")]
public object Spec {get;set;}
/// <summary>
/// 商品sku编码
/// </summary>
[JsonProperty("sku_id")]
public int SkuId {get;set;}
/// <summary>
/// 商品sku库存
/// </summary>
[JsonProperty("sku_quantity")]
public int SkuQuantity {get;set;}
/// <summary>
/// 商家外部编码（sku），同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）。
/// </summary>
[JsonProperty("outer_id")]
public object OuterId {get;set;}
/// <summary>
/// 商家外部编码（商品），同其他接口中的outer_goods_id 、out_goods_id、out_goods_sn、outer_goods_sn 都为商家编码（goods维度）。
/// </summary>
[JsonProperty("outer_goods_id")]
public object OuterGoodsId {get;set;}
/// <summary>
/// sku预览图
/// </summary>
[JsonProperty("sku_img")]
public object SkuImg {get;set;}
/// <summary>
/// 拼团价格（元）
/// </summary>
[JsonProperty("group_price")]
public int GroupPrice {get;set;}
/// <summary>
/// 单买价格（元）
/// </summary>
[JsonProperty("single_price")]
public int SinglePrice {get;set;}
/// <summary>
/// 商品sku是否上架，0-下架，1-上架
/// </summary>
[JsonProperty("is_sku_onsale")]
public int IsSkuOnsale {get;set;}

    public partial class GoodsInfoGetResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 商品详情对象
/// </summary>
[JsonProperty("goods_info")]
public object GoodsInfo {get;set;}

}

    public partial class GoodsInfoResponseModel : PddResponseModel
    {
        /// <summary>
/// 商品编码
/// </summary>
[JsonProperty("goods_id")]
public object GoodsId {get;set;}
/// <summary>
/// 商品序列编码
/// </summary>
[JsonProperty("goods_sn")]
public object GoodsSn {get;set;}
/// <summary>
/// 商品类型，1-普通商品，2-进口商品，3-直供，4-直邮
/// </summary>
[JsonProperty("goods_type")]
public int GoodsType {get;set;}
/// <summary>
/// 商品一级类目
/// </summary>
[JsonProperty("goods_category")]
public object GoodsCategory {get;set;}
/// <summary>
/// 叶子类目
/// </summary>
[JsonProperty("last_category")]
public object LastCategory {get;set;}
/// <summary>
/// 是否七天无理由售后，0-不支持，1-支持
/// </summary>
[JsonProperty("is_refundable")]
public int IsRefundable {get;set;}
/// <summary>
/// 承诺发货时间
/// </summary>
[JsonProperty("shipment_limit_second")]
public object ShipmentLimitSecond {get;set;}
/// <summary>
/// 商品名称
/// </summary>
[JsonProperty("goods_name")]
public object GoodsName {get;set;}
/// <summary>
/// 商品图片 url
/// </summary>
[JsonProperty("image_url")]
public object ImageUrl {get;set;}
/// <summary>
/// 商品库存
/// </summary>
[JsonProperty("goods_quantity")]
public int GoodsQuantity {get;set;}
/// <summary>
/// 商品是否上架，0-下架，1-上架；
/// </summary>
[JsonProperty("is_onsale")]
public int IsOnsale {get;set;}
/// <summary>
/// 商品是否全新，0-全新商品，1-二手商品
/// </summary>
[JsonProperty("second_hand")]
public int SecondHand {get;set;}
/// <summary>
/// 成团人数
/// </summary>
[JsonProperty("group_required_customer_num")]
public int GroupRequiredCustomerNum {get;set;}
/// <summary>
/// sku列表对象
/// </summary>
[JsonProperty("sku_list")]
public object SkuList {get;set;}

}

    public partial class SkuListResponseModel : PddResponseModel
    {
        /// <summary>
/// 商品规格名称
/// </summary>
[JsonProperty("spec")]
public object Spec {get;set;}
/// <summary>
/// 商品sku编码
/// </summary>
[JsonProperty("sku_id")]
public int SkuId {get;set;}
/// <summary>
/// 商品sku库存
/// </summary>
[JsonProperty("sku_quantity")]
public int SkuQuantity {get;set;}
/// <summary>
/// 商家外部编码（sku），同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）。
/// </summary>
[JsonProperty("outer_id")]
public object OuterId {get;set;}
/// <summary>
/// 商家外部编码（商品），同其他接口中的outer_goods_id 、out_goods_id、out_goods_sn、outer_goods_sn 都为商家编码（goods维度）。
/// </summary>
[JsonProperty("outer_goods_id")]
public object OuterGoodsId {get;set;}
/// <summary>
/// sku预览图
/// </summary>
[JsonProperty("sku_img")]
public object SkuImg {get;set;}
/// <summary>
/// 拼团价格（元）
/// </summary>
[JsonProperty("group_price")]
public int GroupPrice {get;set;}
/// <summary>
/// 单买价格（元）
/// </summary>
[JsonProperty("single_price")]
public int SinglePrice {get;set;}
/// <summary>
/// 商品sku是否上架，0-下架，1-上架
/// </summary>
[JsonProperty("is_sku_onsale")]
public int IsSkuOnsale {get;set;}

}

}
}