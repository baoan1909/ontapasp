<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CapNhat.aspx.cs" Inherits="DoBaoAn_CCN04B.CapNhat" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
            <div class="body">
                    <table>
                    <tr>
                        <td>
                            DANH SÁCH MÔN HỌC
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Mã môn học: <asp:TextBox ID="txtMamonhoc" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Tên môn học: <asp:TextBox ID="txtTenmonhoc" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="text">
                            <div>
                                 <asp:GridView ID="gdvMonhoc" class="body" runat="server" AutoGenerateColumns="False" CellPadding="4"  ForeColor="#333333" GridLines="None" PageSize="3" HorizontalAlign="Center" BackColor="White" OnPageIndexChanging="gdvMonhoc_PageIndexChanging" OnSelectedIndexChanged="gdvMonhoc_SelectedIndexChanged" AllowPaging="True">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="MaMH" HeaderText="Mã môn học" />
                                    <asp:BoundField DataField="TenMH" HeaderText="Tên môn học" />
                                    <asp:CommandField SelectText="Chọn" ShowSelectButton="True" />
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
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblLoi" runat="server" ForeColor="Red" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnThem" runat="server" Text="Thêm" OnClick="btnThem_Click"  /> 
                            <asp:Button ID="btnLuu" runat="server" Text="Lưu" OnClick="btnLuu_Click"  />
                            <asp:Button ID="btnXoa" runat="server" Text="Xóa" OnClick="btnXoa_Click" />
                            <asp:Button ID="btnSua" runat="server" Text="Sửa" OnClick="btnSua_Click" />
                        </td>
                    </tr>
                    
                </table>
            </div>
        </div>
</asp:Content>
