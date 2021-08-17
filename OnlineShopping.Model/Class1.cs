using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Model
{
    class Class1
    {
        //外协单位管理 outsourcetable
        //外协单位id               outsourceid         int
        //名称                     outsourcename       varchar(50)
        //手机号                   outsourcephone      varchar(20)
        //邮箱                     outsourcemail       varchar(100)
        //地址                     outsourceaddress    varchar(300)
        //固话                     outsourcefix        varchar(20)
        //备注                     outsourceremark     varchar(100)
        //时间                     outsourcedate       date
        //操作                     outsourcesale       int
        //油费管理                 oil
        //Id                                                                            oilid                   int
        //车牌号                                                                        oilnumber               varchar(50)
        //加油费用                                                                      oilcost                 money
        //加油量                                                                        oilcharge               int
        //起始公里数                                                                    oilcount                varchar(100)
        //支付方式                                                                      oiltype                 varchar(50)
        // （微信支付、支付宝支付、银联支付、 企业转账、线下支付、其他支付方式）                               
        //经办人                                                                        oilpeople               varchar(50)
        //备注                                                                          oilback                 varchar(300)
        //创建时间                                                                      oildate                 date
        //状态                                                                          oilsale                 varchar(50)
        //线路管理 linetable
        //            id                lineid                    itn
        //            名称              linename                  varchar(50)
        //            起点              lineorigin                varchar(50)
        //            地址              lineoriginaddress         varchar(50)
        //            终点              lineend                   varchar(50)
        //            终点地址          lineendaddress            varchar(50)
        //            是否外协          lineoutsource             int
        //            货主姓名          lineownername             varchar(50)
        //            手机号            linephone                 varchar(50)
        //            单位              lineunit                  varchar(50)
        //            备注              lineback                  varchar(50)
        //            时间              linedate                 date
        //            窗台              linesale                  int
        //            是否启用          linestart                int
        //员工登记 employeetable
        //           id              employeeid                int 
        //           姓名            employeename              varchar(50)
        //           性别            employeesex               int 
        //           手机号          employeephone             varchar(20)
        //           院校            employeeacademy           varcahr(30)
        //           专业            employeemajor             varcahr(30)
        //           地址            employeeaddress           varcahr(300)
        //           学历            employeeeducation         varcahr(30)
        //           政治面貌        employeeface              varcahr(300)
        //           民族            employeenation            varcahr(50)
        //           籍贯            employeeplace             varcahr(50)
        //           婚姻状况        employeemarital           int
        //           出生年月日      employeedate              datetime
        //           邮箱            employeemail              varcahr(100)
        //           身份证号        employeecard              varcahr(50)
        //           部门            employeedepartemnt        int
        //           职位            employeeposition          int
        //           员工状态        employeestate             int
        //           入职日期        employeeentry             date
        //           工龄            employeeage               int
        //           工作类型(类别)  employeetype              int
        //           状态            employeesale              int
        //入职办理  entrytable
        //    id               entryid                 int
        //    部门             entrydepartment         int
        //    职位             entryposition           int
        //    姓名             entryname                varchar(50)
        //    负责人           entryprincipal           varchar(20)
        //    入职日期         entrydate               date
        //    备注             entryback                varchar(300)
        //    创建时间         entryestablish           date
        //    审批状态         entryexamine             int
        //    审批人           entryapprover            varchar(20)
        //    状态             entrysale                int
                                                      


      //离职办理     dimissiontable
      //      id                    dimissionid               int
      //      部门                  dimissiondepartment        int
      //      职位                  dimissionposition          int
      //      姓名                  dimissionname              varchar(50)
      //      上级负责人            dimissionprincipal         varchar(20)
      //      入职日期              dimissiondate              date
      //      最后工作日            dimissionlast              date
      //      离职原因              dimissioninfo              varchar(300)
      //      审批状态              dimissionexamine           int
      //      创建时间              dimissionestablish         date
      //      状态                  dimissionsale              int

      //转正办理  fulltable
      //      id                 fullid                  int
      //      姓名               fullname                varchar(50)
      //      部门               fulldepartment          int
      //      职位               fullposition            int
      //      上级负责人         fullprincipal           varchar(50)
      //      入职日期           fulldate                date
      //      申请日期           fullapply               date
      //      试用期工作总结     fullsummary             varchar(300)
      //      对公司的意见       fullopinion             varchar(300)
      //      审批状态           fullexamine             int
      //      创建时间           fullstablish            date
      //      状态               fullsale                int



     //  货主合同管理 cargotable
     //       id                           cargoid                int
     //       标题                         cargotitle             varchar(100)
     //       货主单位                     cargounit              varchar(50)
     //       货主负责人                   cargoprincipal         varchar(50)
     //       线路                         cargoline              varchar(50)
     //       吨位价                       cargotonnage           money
     //       包车条件吨位                 cargocondition         int
     //       包车金额                     cargomoney             money
     //       经办人                       cargooperator          varchar(50)
     //       签订时间                     cargocontract          date
     //       合同金额                     cargovalue             money
     //       合同标的或项目说明           cargoexplain           varchar(300)
     //       合同主要条款                 cargoclause            varchar(300)
     //       合同文本                     cargotext              varchar(300)
     //       创建时间                     cargoestablish         date
     //       合同状态                     cargostate             int
     //       审批人                       cargoapprover          varchar(50)
     //       操作                         cargosale              int

     //承运合同管理   carriagetable
     //       id                        carriageid                int
     //       合同标题                  carriagetitle             varchar(100)
     //       承运单位                  carriageunit              varchar(50)
     //       承运负责人                carriageprincipal         varchar(50)
     //       线路                      carriageline              varchar(50)
     //       吨位价                    carriagetonnage           money
     //       包车条件吨位              carriagecondition         int
     //       包车金额                  carriagemoney             money
     //       经办人                    carriageoperator          varchar(50)
     //       签订日期                  carriagecontract          date
     //       合同金额                  carriagevalue             money
     //       合同的标或项目说明        carriageexplain           varchar(300)
     //       合同主要条款              carriagelause             varchar(300)
     //       合同文本                  carriagetext              varchar(300)
     //       创建时间                  carriageestablish         date
     //       合同状态                  carriagestate             int
     //       审批人                    carriageapprover          varchar(50)
     //       操作                      carriagesale              int


     //通用合同管理             generaltable
     //       id                      generalid                int
     //       合同标题                generaltitle             varchar(100)
     //       对方单位                generalunit              varchar(50)
     //       对方负责人              generalprincipal         varchar(50)
     //       合同类别                generaltype              int
     //       签订时间                generalcontract          date
     //       经办人                  generaloperator          varchar(50)
     //       合同金额                generalvalue             money
     //       合同的标或合同说明      generalexplain           varchar(300)
     //       合同主要条款            generallause             varchar(300)
     //       合同文本                generaltext              varchar(300)
     //       创建时间                generalestablish         date
     //       合同状态                generalstate             int
     //       审批人                  generalapprover          varchar(50)
     //       操作                    generalsale              int

     //应收费用管理 receivabletable
     //       id              receivableid              id
     //       货主单位        receivableunid            varchar(50）
     //       结算方式        receivablesettle          int
     //       吨位            receivabletonnage         int
     //       单价            receivableprice           money
     //       金额            receivablemoney           money
     //       业务日期        receivablebusiness        date
     //       经办人          receivableoperator        varchar(50）
     //       备注            receivableremark          varchar(50）
     //       创建日期        receivableestab           date
     //       核对状态        receivableestablish       int
     //       核对人          receivablecollator        varchar(50）
     //       核对时间        receivablecheck           date
     //       操作            receivablesale            sale

     //应付费用 payabletable
     //        id            payableid                   id
     //       外协单位       payableoutsource            varchar(50)
     //       结算方式       payablesettle               int
     //       吨位           payabletonnage              int
     //       单价           payableprice                money
     //       金额           payablemoney                money
     //       业务日期       payablebusiness             date
     //       经办人         payableoperator             varchar(50)
     //       备注           payableremark               varchar(50)
     //       创建时间       payableestab                date
     //       核对状态       payableestablish            sale
     //       核对人         payableecollator            varchar(50)
     //       核对时间       payablecheck                date
     //       操作           payablesale                 sale


     //进项发票 incometable
     //       id            incomeid                id
     //       往来单位      incomeunit              varchar(50)
     //       发票类型      incometype              int
     //       发票金额      incomemoney             money
     //       税率          incometax               money
     //       税额          incomeamount            int
     //       开票时间      incomeinvoice           date
     //       备注          incomeremark            varchar(50)
     //       制单人        incomeprepared          varchar(50)
     //       创建时间      incomeestblish          datetime
     //       操作          incomesale              int

     //销项发票管理 outputtable
     //       id           outputid                int
     //       客户名称     outputname              varchar(50)
     //       发票类型     outputtype              int
     //       发票金额     outputmoney             money
     //       税率         outputtax               money
     //       税额         outputamount            int
     //       开票日期     outputinvoice           date
     //       备注         outputremark            varchar(50)
     //       制单人       outputrepared           varchar(50)
     //       创建时间     outputstblish           datetime
     //       操作         outputsale              int



    }
}
