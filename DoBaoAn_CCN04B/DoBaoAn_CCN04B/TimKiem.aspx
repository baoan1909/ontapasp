<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="TimKiem.aspx.cs" Inherits="DoBaoAn_CCN04B.TimKiem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
           <div class="body">
                    <table>
                    <tr>
                        <td>
                            TÌM KIẾM THÔNG TIN MÔN HỌC
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Nhập mã môn học: <asp:TextBox ID="txtMamonhoc" runat="server"></asp:TextBox>
                            <asp:Button ID="btnTimMa" runat="server" Text="Tìm theo mã" OnClick="btnTimMa_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Nhập tên môn học: <asp:TextBox ID="txtTenmonhoc" runat="server"></asp:TextBox>
                            <asp:Button ID="btnTimMon" runat="server" Text="Tìm theo tên" OnClick="btnTimMon_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:GridView ID="gdvMonhoc" class="body" runat="server" AutoGenerateColumns="False">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="MaMH" HeaderText="Mã môn học" />
                                    <asp:BoundField DataField="TenMH" HeaderText="Tên môn học" />
                                </Columns>
                                <EditRowStyle BackColor="#2461BF" />
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#0066CC" />
                                <RowStyle BackColor="#EFF3FB" />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                <SortedDescendingHeaderStyle BackColor="#4870BE" />
                            </asp:GridView>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblLoi" runat="server" ForeColor="Red" Text=""></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
</asp:Content>
