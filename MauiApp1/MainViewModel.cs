using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace MauiApp1;

public partial class MainViewModel : ObservableObject
{
    public static string myPath = "C:\\Users\\Daiana\\Downloads\\country-flags-main\\png100px";
    //public static string myPath = "C:\\Users\\Daiana\\Downloads\\country-flags-main\\svg";

    public ObservableCollection<Model> MyModelCollection { get; set; }

    public MainViewModel()
    {

        MyModelCollection = new ObservableCollection<Model>()
           {new Model { Name = "ad", ImagePath = Path.Combine(myPath, "ad.png") },
            new Model { Name = "ae", ImagePath = Path.Combine(myPath, "ae.png") },
            new Model { Name = "af", ImagePath = Path.Combine(myPath, "af.png") },
            new Model { Name = "ag", ImagePath = Path.Combine(myPath, "ag.png") },
            new Model { Name = "ai", ImagePath = Path.Combine(myPath, "ai.png") },
            new Model { Name = "al", ImagePath = Path.Combine(myPath, "al.png") },
            new Model { Name = "am", ImagePath = Path.Combine(myPath, "am.png") },
            new Model { Name = "ao", ImagePath = Path.Combine(myPath, "ao.png") },
            new Model { Name = "ar", ImagePath = Path.Combine(myPath, "ar.png") },
            new Model { Name = "as", ImagePath = Path.Combine(myPath, "as.png") },
            new Model { Name = "at", ImagePath = Path.Combine(myPath, "at.png") },
            new Model { Name = "au", ImagePath = Path.Combine(myPath, "au.png") },
            new Model { Name = "aw", ImagePath = Path.Combine(myPath, "aw.png") },
            new Model { Name = "ax", ImagePath = Path.Combine(myPath, "ax.png") },
            new Model { Name = "az", ImagePath = Path.Combine(myPath, "az.png") },
            new Model { Name = "ba", ImagePath = Path.Combine(myPath, "ba.png") },
            new Model { Name = "bb", ImagePath = Path.Combine(myPath, "bb.png") },
            new Model { Name = "bd", ImagePath = Path.Combine(myPath, "bd.png") },
            new Model { Name = "be", ImagePath = Path.Combine(myPath, "be.png") },
            new Model { Name = "bf", ImagePath = Path.Combine(myPath, "bf.png") },
            new Model { Name = "bg", ImagePath = Path.Combine(myPath, "ir.png") },
            new Model { Name = "bh", ImagePath = Path.Combine(myPath, "kr.png") },
            new Model { Name = "bi", ImagePath = Path.Combine(myPath, "id.png") },
            new Model { Name = "bj", ImagePath = Path.Combine(myPath, "bj.png") },
            new Model { Name = "bl", ImagePath = Path.Combine(myPath, "bl.png") },
            new Model { Name = "bm", ImagePath = Path.Combine(myPath, "bm.png") },
            new Model { Name = "bn", ImagePath = Path.Combine(myPath, "bn.png") },
            new Model { Name = "bo", ImagePath = Path.Combine(myPath, "bo.png") },
            new Model { Name = "bq", ImagePath = Path.Combine(myPath, "bq.png") },
            new Model { Name = "br", ImagePath = Path.Combine(myPath, "br.png") },
            new Model { Name = "bs", ImagePath = Path.Combine(myPath, "bs.png") },
            new Model { Name = "bt", ImagePath = Path.Combine(myPath, "bt.png") },
            new Model { Name = "bv", ImagePath = Path.Combine(myPath, "bv.png") },
            new Model { Name = "bw", ImagePath = Path.Combine(myPath, "bw.png") },
            new Model { Name = "by", ImagePath = Path.Combine(myPath, "by.png") },
            new Model { Name = "bz", ImagePath = Path.Combine(myPath, "bz.png") },
            new Model { Name = "ca", ImagePath = Path.Combine(myPath, "ca.png") },
            new Model { Name = "cc", ImagePath = Path.Combine(myPath, "cc.png") },
            new Model { Name = "cd", ImagePath = Path.Combine(myPath, "cd.png") },
            new Model { Name = "cf", ImagePath = Path.Combine(myPath, "cf.png") },
            new Model { Name = "cg", ImagePath = Path.Combine(myPath, "cg.png") },
            new Model { Name = "ch", ImagePath = Path.Combine(myPath, "ci.png") },
            new Model { Name = "ci", ImagePath = Path.Combine(myPath, "ci.png") }
    };
    }
}
