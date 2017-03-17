﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="contrato_convenio.aspx.cs" Inherits="Transparencia.pages.ContratoConvenio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ControlContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Contratos e Convênios</h2>

    <div style="position: relative;">

        <ej:Grid ID="gvContratosConvenios" runat="server"
            AllowFiltering="True"
            AllowSorting="True"
            AllowPaging="True"
            AllowSelection="False"
            EnableRowHover="False"
            ClientIDMode="Static"
            AllowResizeToFit="True"
            AllowGrouping="True"
            Locale="pt-BR"
            >

            <GroupSettings ShowDropArea="True" EnableDropAreaAutoSizing="False" ShowToggleButton="True" ShowUngroupButton="True"></GroupSettings>

            <FilterSettings FilterType="Menu"></FilterSettings>

            <Columns>
                <ej:Column Field="codigoProcesso" HeaderText="Código Processo" Visible="False">
                </ej:Column>
                <ej:Column Field="nomeArquivoPDF" HeaderText="Nome Arquivo PDF" Visible="False">
                </ej:Column>
                <ej:Column Field="ano" Width="5%" HeaderText="Ano" AllowGrouping="True">
                </ej:Column>
                <ej:Column Field="numeroProcesso" HeaderText="Número Processo" AllowGrouping="True">
                </ej:Column>
                <ej:Column Field="contratada" HeaderText="Contratada" AllowGrouping="True">
                </ej:Column>
                <ej:Column Field="modalidade" HeaderText="Modalidade" AllowGrouping="True">
                </ej:Column>
                <ej:Column Field="finalizado" HeaderText="Finalizado" AllowGrouping="True">
                </ej:Column>
                <ej:Column Field="vigenciaInicial" HeaderText="Vigência Inicial" AllowFiltering="False" AllowGrouping="False">
                </ej:Column>
                <ej:Column Field="vigenciaFinal" HeaderText="Vigência Final" AllowFiltering="False" AllowGrouping="False">
                </ej:Column>
                <ej:Column Field="dataContrato" HeaderText="Data do Contrato" AllowFiltering="False" AllowGrouping="False">
                </ej:Column>
                <ej:Column Field="vigenciaProrrogada" HeaderText="Vigência Prorrogada" AllowFiltering="False" AllowGrouping="False">
                </ej:Column>
                <ej:Column Field="objeto" HeaderText="Objeto" Visible="False" AllowGrouping="False">
                </ej:Column>
                <ej:Column HeaderText="Detalhes" IsUnbound="True" TextAlign="Left" Width="150" Field="" AllowFiltering="False" AllowGrouping="False">
                    <Command>
                        <ej:Commands Type="detail">
                            <ButtonOptions Text="Detalhes" Width="90%" Height="2%" Click="onClick"></ButtonOptions>
                        </ej:Commands>
                    </Command>
                </ej:Column>
            </Columns>

            <PageSettings PageSize="6" ></PageSettings>

        </ej:Grid>

        <ej:Dialog ID="commanddialog" ClientIDMode="Static" runat="server" Width="800" Title="Detalhes do Contrato" ShowOnInit="false"
            EnableResize="False" Target="#gvContratosConvenios" ShowFooter="True">
        </ej:Dialog>

    </div>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ScriptContent" runat="server">
    <script id="templateData" type="text/x-jsrender">
        <table>
            <tr>
                <td class="td-grid">Número do Processo:</td>
                <td>{{:numeroProcesso}} </td>
            </tr>
            <tr>
                <td class="td-grid">Razão Social:</td>
                <td>{{:contratada}} </td>
            </tr>
            <tr>
                <td class="td-grid">Modalidade:</td>
                <td>{{:modalidade}} </td>
            </tr>
            <tr>
                <td class="td-grid">Data do Contrato:</td>
                <td>{{:dataContrato}} </td>
            </tr>
            <tr>
                <td class="td-grid">Vigência Inicial:</td>
                <td>{{:vigenciaInicial}} </td>
            </tr>
            <tr>
                <td class="td-grid">Vigência Final:</td>
                <td>{{:vigenciaFinal}} </td>
            </tr>
            <tr>
                <td class="td-grid">Vigência Prorrogada:</td>
                <td>{{:vigenciaProrrogada}} </td>
            </tr>
            <tr>
                <td class="td-grid">Objeto do Contrato:</td>
                <td>{{:objeto}} </td>
            </tr>
            <tr>
                <td class="td-grid">Encerrado?</td>
                <td>{{:finalizado}} </td>
            </tr>
            <tr>
                <td class="td-grid"></td>
                <td>&#013;</td>
            </tr>
            <tr>
                <td class="td-grid"></td>
                <td>&#013;</td>
            </tr>
            <tr>
                <td class="td-grid">Visualizar contrato:</td>
                <td>
                    <a href="http://sistemas.defensoria.ms.gov.br/ajfile/arquivos/PROCESSOS/{{:codigoProcesso}}/{{:nomeArquivoPDF}}" target="_blank">Clique aqui.</a>
                </td>
            </tr>
        </table>
    </script>

    <script type="text/javascript">
        function onClick(args) {
            var grid = $("#gvContratosConvenios").ejGrid("instance");
            var index = this.element.closest("tr").index();
            var record = grid.getCurrentViewData()[index];
            record["BirthDate"] = ej.format(record["BirthDate"], "MM/dd/yyyy");
            $("#commanddialog").html($("#templateData").render(record))
                .ejDialog("option", { position: { X: this.element.position().left - 755, Y: this.element.position().top } })
                .ejDialog("open");
            if (navigator.userAgent.indexOf("MSIE 8.0") != -1)
                $("#commanddialog").find("img").width(150);
        }
    </script>

    <script type="text/javascript">
        ej.Grid.Locale["pt-BR"] = {
            GroupDropArea: "Arraste o cabeçalho das colunas para a área azul para agrupá-las",
            Columns: "Colunas"
        };
        if (ej.Pager) ej.Pager.Locale["pt-BR"] = {
            pagerInfo: "{0} de {1} páginas ({2} itens)",
            firstPageTooltip: "Ir para a primeira página",
            lastPageTooltip: "Ir para a última página",
            nextPageTooltip: "Ir para a próxima página",
            previousPageTooltip: "Ir para a página anterior",
            nextPagerTooltip: "Ir para a próxima página",
            previousPagerTooltip: "Ir para página anterior"
        };
    </script>

</asp:Content>
