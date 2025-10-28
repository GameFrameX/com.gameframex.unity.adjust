// GameFrameX 组织下的以及组织衍生的项目的版权、商标、专利和其他相关权利均受相应法律法规的保护。使用本项目应遵守相关法律法规和许可证的要求。
// 
// 本项目主要遵循 MIT 许可证和 Apache 许可证（版本 2.0）进行分发和使用。许可证位于源代码树根目录中的 LICENSE 文件。
// 
// 不得利用本项目从事危害国家安全、扰乱社会秩序、侵犯他人合法权益等法律法规禁止的活动！任何基于本项目二次开发而产生的一切法律纠纷和责任，我们不承担任何责任！

#if ENABLE_GAME_FRAME_X_ADJUST
using AdjustSdk;
#endif
using System.Collections.Generic;
using GameFrameX.Runtime;

namespace GameFrameX.AdJust.Runtime
{
    [UnityEngine.Scripting.Preserve]
    public sealed class AdJustManager : GameFrameworkModule, IAdJustManager
    {
        [UnityEngine.Scripting.Preserve]
        public AdJustManager()
        {
        }


        /// <summary>
        /// 初始化 AdJust SDK
        /// </summary>
        /// <param name="debug">是否启用调试模式，启用后会输出详细的日志信息</param>
        /// <param name="appToken">AdJust SDK的App Token，用于初始化AdJust SDK</param>
        /// <param name="logLevel">日志级别，用于控制输出的日志详细程度</param>
        /// <param name="environment">环境类型，用于指定AdJust SDK运行的环境（例如生产环境或沙箱环境）</param>
        [UnityEngine.Scripting.Preserve]
        public void Init(bool debug, string appToken, AdjustLogLevel logLevel, AdjustEnvironment environment)
        {
#if ENABLE_GAME_FRAME_X_ADJUST
            var adjust = UnityEngine.Object.FindObjectOfType<Adjust>();

            if (adjust.startManually)
            {
                AdjustConfig adjustConfig = new AdjustConfig(appToken, environment);
                if (debug)
                {
                    adjustConfig.LogLevel = AdjustLogLevel.Verbose;
                }

                Adjust.InitSdk(adjustConfig);
            }
#endif
        }

        /// <summary>
        /// 发送自定义事件到 Adjust
        /// </summary>
        /// <param name="eventName">事件名称，用于标识特定的用户行为或应用内事件</param>
        /// <param name="eventValues">事件参数字典，包含与事件相关的键值对数据</param>
        /// <param name="productId">产品ID，用于标识特定的商品或服务</param>
        /// <param name="transactionId">交易ID，用于标识唯一的交易记录</param>
        /// <param name="revenue">事件收入金额，单位为货币单位</param>
        /// <param name="currency">货币单位，例如 "USD"、"EUR" 等</param>
        public void Event(string eventName, Dictionary<string, string> eventValues, string productId = null, string transactionId = null, double revenue = 0, string currency = "USD")
        {
#if ENABLE_GAME_FRAME_X_ADJUST
            AdjustEvent adjustEvent = new AdjustEvent(eventName);
            foreach (var kv in eventValues)
            {
                adjustEvent.AddPartnerParameter(kv.Key, kv.Value);
            }

            adjustEvent.SetRevenue(revenue, currency);

            adjustEvent.ProductId = productId;
            adjustEvent.TransactionId = transactionId;
            Adjust.TrackEvent(adjustEvent);
#endif
        }

        /// <summary>
        /// 发送广告事件到 Adjust
        /// </summary>
        /// <param name="eventName">事件名称，用于标识特定的用户行为或应用内事件</param>
        /// <param name="revenue">广告收入金额，单位为货币单位</param>
        /// <param name="currency">货币单位，例如 "USD"、"EUR" 等</param>
        /// <param name="adRevenueNetwork">广告网络名称，例如 "AdMob"、"Facebook" 等</param>
        /// <param name="adRevenuePlacement">广告 placement ID，用于标识广告位置</param>
        /// <param name="adRevenueUnit">广告单位，例如 "impression"、"click" 等</param>
        public void EventAd(string eventName, double revenue, string currency, string adRevenueNetwork = null, string adRevenuePlacement = null, string adRevenueUnit = null)
        {
#if ENABLE_GAME_FRAME_X_ADJUST
            var adjustAdRevenue = new AdjustAdRevenue(eventName);
            adjustAdRevenue.SetRevenue(revenue, currency);
            adjustAdRevenue.AdRevenueNetwork = adRevenueNetwork;
            adjustAdRevenue.AdRevenuePlacement = adRevenuePlacement;
            adjustAdRevenue.AdRevenueUnit = adRevenueUnit;
            Adjust.TrackAdRevenue(adjustAdRevenue);
#endif
        }

        protected override void Update(float elapseSeconds, float realElapseSeconds)
        {
        }

        protected override void Shutdown()
        {
        }
    }
}