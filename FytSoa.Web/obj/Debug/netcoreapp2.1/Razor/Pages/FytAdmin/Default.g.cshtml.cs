#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a949efd1de83ee9b6bb9192608b236e518d2f663"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Pages_FytAdmin_Default), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Default.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Pages_FytAdmin_Default), null)]
namespace FytSoa.Web.Pages.FytAdmin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a949efd1de83ee9b6bb9192608b236e518d2f663", @"/Pages/FytAdmin/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Default : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/js/echarts.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/js/macarons.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Default.cshtml"
  
    ViewData["Title"] = "默认页";
    Layout = AdminLayout.Pjax(HttpContext);

#line default
#line hidden
            BeginContext(138, 20073, true);
            WriteLiteral(@"<div id=""container"">
    <style>
        body {
            background-color: #f1f4f5;
        }
    </style>
    <div class=""layui-fluid"">
        <div class=""layui-row layui-col-space15"">
            <div class=""layui-col-md8"">
                <div class=""layui-row layui-col-space15"">
                    <div class=""layui-col-md6"">
                        <div class=""layui-card"">
                            <div class=""layui-card-header"">快捷方式</div>
                            <div class=""layui-card-body"">
                                <div class=""layui-carousel layadmin-carousel layadmin-shortcut"" id=""shortcut"" lay-anim="""" lay-indicator=""inside"" lay-arrow=""none"">
                                    <div carousel-item>
                                        <ul class=""layui-row layui-col-space10 layui-this"">
                                            <li class=""layui-col-xs3"">
                                                <a href=""component/layer/list"">
                              ");
            WriteLiteral(@"                      <i class=""layui-icon layui-icon-website""></i>
                                                    <cite>条形码</cite>
                                                </a>
                                            </li>
                                            <li class=""layui-col-xs3"">
                                                <a href=""component/button/"">
                                                    <i class=""layui-icon layui-icon-find-fill""></i>
                                                    <cite>采购</cite>
                                                </a>
                                            </li>
                                            <li class=""layui-col-xs3"">
                                                <a href=""component/progress/"">
                                                    <i class=""layui-icon layui-icon-loading-2""></i>
                                                    <cite>会员</cite>
                                 ");
            WriteLiteral(@"               </a>
                                            </li>
                                            <li class=""layui-col-xs3"">
                                                <a href=""/senior/im/"">
                                                    <i class=""layui-icon layui-icon-chat""></i>
                                                    <cite>加盟商</cite>
                                                </a>
                                            </li>
                                            <li class=""layui-col-xs3"">
                                                <a href=""component/panel/"">
                                                    <i class=""layui-icon layui-icon-read""></i>
                                                    <cite>入库</cite>
                                                </a>
                                            </li>
                                            <li class=""layui-col-xs3"">
                                              ");
            WriteLiteral(@"  <a href=""component/badge/"">
                                                    <i class=""layui-icon layui-icon-tree""></i>
                                                    <cite>出库</cite>
                                                </a>
                                            </li>
                                            <li class=""layui-col-xs3"">
                                                <a href=""/set/system/website"">
                                                    <i class=""layui-icon layui-icon-set""></i>
                                                    <cite>调拨</cite>
                                                </a>
                                            </li>
                                            <li class=""layui-col-xs3"">
                                                <a href=""/set/user/password"">
                                                    <i class=""layui-icon layui-icon-set""></i>
                                                    <cit");
            WriteLiteral(@"e>退货</cite>
                                                </a>
                                            </li>
                                        </ul>
                                        <ul class=""layui-row layui-col-space10"">
                                            <li class=""layui-col-xs3"">
                                                <a href=""component/layer/list"">
                                                    <i class=""layui-icon layui-icon-website""></i>
                                                    <cite>返货</cite>
                                                </a>
                                            </li>
                                            <li class=""layui-col-xs3"">
                                                <a href=""component/button/"">
                                                    <i class=""layui-icon layui-icon-find-fill""></i>
                                                    <cite>财务</cite>
                               ");
            WriteLiteral(@"                 </a>
                                            </li>
                                            <li class=""layui-col-xs3"">
                                                <a href=""component/progress/"">
                                                    <i class=""layui-icon layui-icon-loading-2""></i>
                                                    <cite>销售报表</cite>
                                                </a>
                                            </li>
                                            <li class=""layui-col-xs3"">
                                                <a href=""/senior/im/"">
                                                    <i class=""layui-icon layui-icon-chat""></i>
                                                    <cite>积分商品</cite>
                                                </a>
                                            </li>
                                            <li class=""layui-col-xs3"">
                                 ");
            WriteLiteral(@"               <a href=""component/panel/"">
                                                    <i class=""layui-icon layui-icon-read""></i>
                                                    <cite>积分订单</cite>
                                                </a>
                                            </li>

                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""layui-col-md6"">
                        <div class=""layui-card"">
                            <div class=""layui-card-header"">待办事项</div>
                            <div class=""layui-card-body"">
                                <div class=""layui-carousel layadmin-carousel layadmin-backlog"" id=""backlog"" lay-anim="""" lay-indicator=""inside"" lay-arrow=""none"">
                                    <div carousel-item>
                               ");
            WriteLiteral(@"         <ul class=""layui-row layui-col-space10 layui-this"">
                                            <li class=""layui-col-xs6"">
                                                <a lay-href="""" class=""layadmin-backlog-body"">
                                                    <h3>待返货处理</h3>
                                                    <p><cite>66</cite></p>
                                                </a>
                                            </li>
                                            <li class=""layui-col-xs6"">
                                                <a lay-href="""" class=""layadmin-backlog-body"">
                                                    <h3>待退货处理</h3>
                                                    <p><cite>12</cite></p>
                                                </a>
                                            </li>
                                            <li class=""layui-col-xs6"">
                                                <a lay-hre");
            WriteLiteral(@"f="""" class=""layadmin-backlog-body"">
                                                    <h3>库存报警数量</h3>
                                                    <p><cite>99</cite></p>
                                                </a>
                                            </li>
                                            <li class=""layui-col-xs6"">
                                                <a lay-href="""" class=""layadmin-backlog-body"">
                                                    <h3>今日加入会员</h3>
                                                    <p><cite>20</cite></p>
                                                </a>
                                            </li>
                                        </ul>
                                        <ul class=""layui-row layui-col-space10"">
                                            <li class=""layui-col-xs6"">
                                                <a lay-href="""" class=""layadmin-backlog-body"">
                        ");
            WriteLiteral(@"                            <h3>积分订单处理</h3>
                                                    <p><cite style=""color: #FF5722;"">5</cite></p>
                                                </a>
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""layui-col-md12"">
                        <div class=""layui-card"">
                            <div class=""layui-card-header"">数据概览</div>
                            <div class=""layui-card-body"">
                                <div id=""base-map"" style=""width: 100%;height:300px;""></div>
                            </div>
                        </div>
                    </div>
                    <div class=""layui-col-md12"">
                        <div class=""layui-card"">
                            <");
            WriteLiteral(@"div class=""layui-card-header"">品牌销售排行榜 Top10</div>
                            <div class=""layui-card-body"">
                                <div id=""brand-top"" style=""width: 100%;height:355px;""></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""layui-col-md4"">
                <div class=""layui-card"">
                    <div class=""layui-card-header"">版本信息</div>
                    <div class=""layui-card-body layui-text"" style=""height:210px;"">
                        <table class=""layui-table"">
                            <colgroup>
                                <col width=""100"">
                                <col>
                            </colgroup>
                            <tbody>
                                <tr>
                                    <td>欢迎您</td>
                                    <td>
                                        admins超级管理员
      ");
            WriteLiteral(@"                              </td>
                                </tr>
                                <tr>
                                    <td>更新时间</td>
                                    <td>上次登录日期：2018/5/4 22:44:53　　<a href=""/fytadmin/syslog/index"">查看日志</a></td>
                                </tr>
                                <tr>
                                    <td>当前版本</td>
                                    <td>
                                        V1.0.0  pro最后　更新时间：2017-07-20
                                    </td>
                                </tr>
                                <tr>
                                    <td>授权说明</td>
                                    <td>
                                        本系统是北京飞易腾科技有限公司授权予 飞易腾 使用！
                                    </td>
                                </tr>
                                <tr>
                                    <td>求助帮助</td>
                                    <td>
          ");
            WriteLiteral(@"                              <a href="""" class=""layui-badge layui-bg-blue"">联系客服</a>　　<span class=""layui-badge layui-bg-gray"">13511084034</span>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
                <div class=""layui-card"">
                    <div class=""layui-card-header"">销售统计</div>
                    <div class=""layui-card-body"">
                        <div class=""layui-row fyt-counter"">
                            <div class=""layui-col-md4"">
                                <div class=""counter-label"">今日</div>
                                <div class=""counter-number red-600"">20,186</div>
                            </div>
                            <div class=""layui-col-md4"">
                                <div class=""counter-label"">本周</div>
                                <div class=""counter-number red-600"">20,186</div>
    ");
            WriteLiteral(@"                        </div>
                            <div class=""layui-col-md4"">
                                <div class=""counter-label"">本月</div>
                                <div class=""counter-number red-600"">20,186</div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""layui-card"">
                    <div class=""layui-card-header"">销售统计效果</div>
                    <div class=""layui-card-body layadmin-takerates"">
                        <div class=""layui-progress"" lay-showpercent=""yes"">
                            <h3>转化率（日同比 28% <span class=""layui-edge layui-edge-top"" lay-tips=""增长"" lay-offset=""-15""></span>）</h3>
                            <div class=""layui-progress-bar"" lay-percent=""65%""><span class=""layui-progress-text"">65%</span></div>
                        </div>
                        <div class=""layui-progress"" lay-showpercent=""yes"">
                            <h3>签到率（周同比 11%");
            WriteLiteral(@" <span class=""layui-edge layui-edge-bottom"" lay-tips=""下降"" lay-offset=""-15""></span>）</h3>
                            <div class=""layui-progress-bar layui-bg-orange"" lay-percent=""32%""><span class=""layui-progress-text"">32%</span></div>
                        </div>
                        <div class=""layui-progress"" lay-showpercent=""yes"">
                            <h3>签到率（月同比 65% <span class=""layui-edge layui-edge-bottom"" lay-tips=""下降"" lay-offset=""-15""></span>）</h3>
                            <div class=""layui-progress-bar layui-bg-orange"" lay-percent=""65%""><span class=""layui-progress-text"">32%</span></div>
                        </div>
                    </div>
                </div>
                <div class=""layui-card"">
                    <div class=""layui-card-header"">店铺销售排行榜</div>
                    <div class=""layui-card-body fyt-shoptop"">
                        <table class=""layui-table"">
                            <colgroup>
                                <col>
              ");
            WriteLiteral(@"                  <col width=""80"">
                                <col width=""90"">
                                <col width=""150"">
                            </colgroup>
                            <thead>
                                <tr>
                                    <th>加盟商名称</th>
                                    <th>总金额</th>
                                    <th>订单总数</th>
                                    <th>占比</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>秦皇岛店秦皇岛店</td>
                                    <td>￥56412.15</td>
                                    <td>2345</td>
                                    <td>
                                        <div class=""layui-progress"" lay-showpercent=""true"">
                                            <div class=""layui-progress-bar"" lay-percent=""60%""></div>
                  ");
            WriteLiteral(@"                      </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td>秦皇岛店秦皇岛店</td>
                                    <td>￥56412.15</td>
                                    <td>2345</td>
                                    <td>
                                        <div class=""layui-progress"" lay-showpercent=""true"">
                                            <div class=""layui-progress-bar"" lay-percent=""40%""></div>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td>秦皇岛店秦皇岛店</td>
                                    <td>￥56412.15</td>
                                    <td>2345</td>
                                    <td>
                                        <div class=""layui-progress"" lay-showpercent=""true"">
          ");
            WriteLiteral(@"                                  <div class=""layui-progress-bar"" lay-percent=""35%""></div>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td>秦皇岛店秦皇岛店</td>
                                    <td>￥56412.15</td>
                                    <td>2345</td>
                                    <td>
                                        <div class=""layui-progress"" lay-showpercent=""true"">
                                            <div class=""layui-progress-bar"" lay-percent=""30%""></div>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td>秦皇岛店秦皇岛店</td>
                                    <td>￥56412.15</td>
                                    <td>2345</td>
                                   ");
            WriteLiteral(@" <td>
                                        <div class=""layui-progress"" lay-showpercent=""true"">
                                            <div class=""layui-progress-bar"" lay-percent=""20%""></div>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td>秦皇岛店秦皇岛店</td>
                                    <td>￥56412.15</td>
                                    <td>2345</td>
                                    <td>
                                        <div class=""layui-progress"" lay-showpercent=""true"">
                                            <div class=""layui-progress-bar"" lay-percent=""16%""></div>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td>秦皇岛店秦皇岛店</td>
                                ");
            WriteLiteral(@"    <td>￥56412.15</td>
                                    <td>2345</td>
                                    <td>
                                        <div class=""layui-progress"" lay-showpercent=""true"">
                                            <div class=""layui-progress-bar"" lay-percent=""5%""></div>
                                        </div>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
    ");
            EndContext();
            BeginContext(20211, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b19cded8b6cc49238c2a8e78965521d9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(20284, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(20290, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e90248c43e9478191a7dc7833c63298", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(20360, 5926, true);
            WriteLiteral(@"
    <script>
        layui.use(['carousel', 'element'], function () {
            var carousel = layui.carousel;
            carousel.render({
                elem: '#shortcut'
                , width: '100%'
                , autoplay: false
                , arrow: 'none'
                , height: '180px'
                , indicator: 'outside'
            });
            carousel.render({
                elem: '#backlog'
                , width: '100%'
                , autoplay: false
                , arrow: 'none'
                , height: '180px'
                , indicator: 'outside'
            });
        });
        var baseChart = echarts.init(document.getElementById('base-map'), 'macarons');
        var option = {
            title: {
                //show:false,
                text: '今日销售金额汇总',
                textStyle: {
                    color: '#888',
                    align: 'center',
                    fontSize: 14,
                    fontWeight: '400'");
            WriteLiteral(@"
                }
            },
            tooltip: {
                trigger: 'axis'
            },
            toolbox: {
                feature: {
                    magicType: {
                        type: ['line', 'bar', 'stack', 'tiled']
                    },
                    saveAsImage: {}
                }
            },
            grid: {
                left: '3%',
                right: '4%',
                bottom: '3%',
                containLabel: true
            },
            xAxis: [
                {
                    type: 'category',
                    boundaryGap: false,
                    data: ['周一', '周二', '周三', '周四', '周五', '周六', '周日']
                }
            ],
            yAxis: [
                {
                    type: 'value'
                }
            ],
            series: [
                {
                    name: '邮件营销',
                    type: 'line',
                    stack: '总量',
                    a");
            WriteLiteral(@"reaStyle: { normal: {} },
                    data: [120, 132, 101, 134, 90, 230, 210]
                },
                {
                    name: '联盟广告',
                    type: 'line',
                    stack: '总量',
                    areaStyle: { normal: {} },
                    data: [220, 182, 191, 234, 290, 330, 310]
                }
            ]
        };
        baseChart.setOption(option);

        var dataAxis = ['芳华店', '击', '柱', '子', '或', '者', '两', '指', '在', '触', '屏', '上', '滑', '动', '能', '够', '自', '动', '缩', '放'];
        var data = [220, 182, 191, 234, 290, 330, 310, 123, 442, 321, 90, 149, 210, 122, 133, 334, 198, 123, 125, 220];
        var yMax = 500;
        var dataShadow = [];
        for (var i = 0; i < data.length; i++) {
            dataShadow.push(yMax);
        }
        var brandChart = echarts.init(document.getElementById('brand-top'), 'macarons');
        brandChart.setOption({
            title: {
                show: false,
            },
     ");
            WriteLiteral(@"       grid: {
                left: '3%',
                right: '4%',
                bottom: '3%',
                containLabel: true
            },
            xAxis: {
                data: dataAxis,
                axisLabel: {
                    inside: true,
                    textStyle: {
                        color: '#fff'
                    }
                },
                axisTick: {
                    show: false
                },
                axisLine: {
                    show: false
                },
                z: 10
            },
            yAxis: {
                axisLine: {
                    show: false
                },
                axisTick: {
                    show: false
                },
                axisLabel: {
                    textStyle: {
                        color: '#999'
                    }
                }
            },
            tooltip: {
                trigger: 'axis'
            },
       ");
            WriteLiteral(@"     toolbox: {
                feature: {
                    magicType: {
                        type: ['line', 'bar', 'stack', 'tiled']
                    },
                    saveAsImage: {}
                }
            },
            series: [
                { // For shadow
                    type: 'bar',
                    itemStyle: {
                        normal: { color: 'rgba(0,0,0,0.05)' }
                    },
                    barGap: '-100%',
                    barCategoryGap: '40%',
                    data: dataShadow,
                    animation: false
                },
                {
                    type: 'bar',
                    itemStyle: {
                        normal: {
                            color: new echarts.graphic.LinearGradient(
                                0, 0, 0, 1,
                                [
                                    { offset: 0, color: '#83bff6' },
                                    { offset: 0.5,");
            WriteLiteral(@" color: '#188df0' },
                                    { offset: 1, color: '#188df0' }
                                ]
                            )
                        },
                        emphasis: {
                            color: new echarts.graphic.LinearGradient(
                                0, 0, 0, 1,
                                [
                                    { offset: 0, color: '#2378f7' },
                                    { offset: 0.7, color: '#2378f7' },
                                    { offset: 1, color: '#83bff6' }
                                ]
                            )
                        }
                    },
                    data: data
                }
            ]
        });

    </script>
</div>
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.DefaultModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.DefaultModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.DefaultModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.DefaultModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
