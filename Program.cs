using System;
using System.Collections.Generic;
namespace Jumat_9_16_2022
{
   public class Program
{
    public static void Main()
    {
        var listnamaDepartment = new List<string>();
        listnamaDepartment.Add("Produksi");
        listnamaDepartment.Add("Keuangan");
        listnamaDepartment.Add("Maintenance");
        var listnamaJabatan = new List<string>();
        listnamaJabatan.Add("Manager");
        listnamaJabatan.Add("Kepala Divisi");
        listnamaJabatan.Add("Anggota");	
        string[] jk= {"Pria","Wanita"};

        bool I = true;
        while(I)
        {
            Console.WriteLine("=======INPUT DATA KARYAWAN=======");
            Console.WriteLine("============== Menu ==============");
            Console.WriteLine("1. Karyawan Baru");
            Console.WriteLine("2. Tampilkan Data Karyawan");
            Console.WriteLine("Lainnya = Keluar");
            Console.WriteLine("==================================");
            var employee = new Employee();
            int menu= int.Parse(Console.ReadLine());
            switch(menu)
            {
                
                case 1: 
                    Console.WriteLine("=======INPUT DATA KARYAWAN=======");
                    Console.WriteLine("============== Menu ==============");
                    Console.Write("Masukan Nama: ");
                    employee.setNama(Console.ReadLine());
                    Console.WriteLine("Jenis Kelamin: ");
                    for(int i=0;i<jk.Length;i++){
                    Console.WriteLine((i+1)+"."+jk[i]);
                    }
                    Console.Write("Pilih Jenis Kelamin: ");
                    int k = int.Parse(Console.ReadLine());
                    employee.setJeniskelamin(jk[k-1]);
                    Console.WriteLine("Daftar Department: ");
                    for(int i=0;i<listnamaDepartment.Count;i++){
                    Console.WriteLine((i+1)+"."+listnamaDepartment[i]);
                    }
                    Console.Write("Pilih Department: ");
                    int d = int.Parse(Console.ReadLine());
                    employee.setDepartment(listnamaDepartment[d-1]);
                    Console.WriteLine("Daftar Jabatan: ");
                    for(int i=0;i<listnamaJabatan.Count;i++){
                    Console.WriteLine((i+1)+"."+listnamaJabatan[i]);
                    }
                    Console.Write("Pilih Jabatan: ");
                    int j = int.Parse(Console.ReadLine());
                    employee.setJabatan(j);
                    var identitas = new Gaji(employee.getJabatan());
                    identitas.tampil(employee.getNama(),employee.getDepartment(),employee.getJabatan());
                    Console.WriteLine(identitas.Process());
                    break;
                case 2:
                    Console.WriteLine("======= DATA KARYAWAN=======");
                    Console.WriteLine("==============  ==============");
                    employee.getNama();
                    break;
                default:
                    Console.WriteLine("anda Keluar");
                    I= false;
                    break;
            }
        }
    }
}

public class Employee
{
    private string Nama ;
	private string Department ;
    private int Jabatan ;
    private string JenisKelamin ;

	
	public void setNama(string  n){
		Nama = n ;
	}
	public string getNama()
	{
		return Nama;
	}

    public void setDepartment(string  d){
		Department = d;
	}
	public string getDepartment()
	{
		return Department;
	}
	
    public void setJabatan(int  j){
		Jabatan = j;
	}
	public int getJabatan()
	{
		return Jabatan;
	}
	public void setJeniskelamin(string jk){
		JenisKelamin = jk;
	}
    public string getJeniskelamin()
    {
        return JenisKelamin;
    }
    
}


public class Gaji : Identitas
{
    public int salary {get;set;}
	
	public Gaji()
	{
		Console.WriteLine("Info Gaji");
	}
    
    public Gaji(int s){
        if (s==1)
        salary =6000;
        else if (s==2)
        salary = 5000;
        else if (s==3)
        salary = 4500;
       
    }
    
    public override double Process(){
        return salary;
    }
}


public abstract class Identitas
    {
        public abstract double Process();
        public void tampil(string n, string d, int j){
            Console.WriteLine("======= Info Karyawan =======");
            Console.WriteLine("Nama :"+n);
            Console.WriteLine("Department :"+d);
            Console.Write("Jabatan :");Console.WriteLine(j);
            Console.Write("Gaji :");
        }
    }
}
