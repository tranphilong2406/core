using System;

namespace RazorPage.Models;

class SanPham{
    String tenSanPham = "";
    int gia;
    String moTa = "";

    public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
    public int Gia { get => gia; set => gia = value; }
    public string MoTa { get => moTa; set => moTa = value; }


}