package javaprograme;
import java.util.Scanner;

public class fabbonaci {
 public static void main(String[] args)
 {
	 int n1=0,n2=1,n3,number,i;
	 System.out.println("enter a number :");
	 Scanner scr=new Scanner(System.in);
	 number=scr.nextInt();
	 System.out.println("print fabbonaci series:-->>");
	 System.out.println(n1+" "+n2+" ");
	 for(i=2;i<=number;i++)
	 {
		 n3=n1+n2;
		 System.out.println(n3);
		 n1=n2;
		 n2=n3;
	 }
 }
}
