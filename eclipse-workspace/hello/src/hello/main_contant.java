package hello;

import java.awt.EventQueue;

import javax.swing.ImageIcon;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.BevelBorder;
import java.awt.SystemColor;
import javax.swing.JLabel;
import java.awt.Font;
import javax.swing.JProgressBar;
import java.awt.Toolkit;
import java.util.Calendar;
import java.util.GregorianCalendar;
import java.awt.Color;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class main_contant {

	private JFrame frame;
	private JLabel Lbltime;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					main_contant window = new main_contant();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	public void clock()
	{
		Thread clock=new Thread()
		{
			public void run()
			{
				try {
					
					Calendar cal=new GregorianCalendar();
					int day=cal.get(Calendar.DAY_OF_MONTH);
					int month=cal.get(Calendar.MONTH);
					int year=cal.get(Calendar.YEAR);
					
					int hour=cal.get(Calendar.HOUR);
					int minuet=cal.get(Calendar.MINUTE);
					int secound=cal.get(Calendar.SECOND);
					 
					Lbltime.setText("Time  "+hour+":"+minuet+":"+secound+"  Date "+day+"/"+month+"/"+year);
					
					sleep(1000);
				} catch (InterruptedException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
			}
		};
		
		clock.start();
		
	}
	/**
	 * Create the application.
	 */
	public main_contant() {
		initialize();
		clock();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.getContentPane().setBackground(Color.DARK_GRAY);
		frame.setBounds(100, 100, 975, 615);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		JPanel panel = new JPanel();
		panel.setBounds(0, 0, 959, 54);
		panel.setBackground(new Color(153, 102, 153));
		frame.getContentPane().add(panel);
		panel.setLayout(null);
		
		JLabel lblNewLabel_1 = new JLabel("Mess Management System");
		lblNewLabel_1.setFont(new Font("Vani", Font.BOLD, 25));
		lblNewLabel_1.setBounds(304, 11, 354, 43);
		panel.add(lblNewLabel_1);
		
		Lbltime = new JLabel("Clock");
		Lbltime.setFont(new Font("Sylfaen", Font.BOLD, 14));
		Lbltime.setForeground(SystemColor.textHighlight);
		Lbltime.setBounds(748, 11, 201, 27);
		panel.add(Lbltime);
		
		JPanel panel_1 = new JPanel();
		panel_1.setBounds(0, 53, 207, 530);
		panel_1.setBackground(SystemColor.activeCaption);
		frame.getContentPane().add(panel_1);
		panel_1.setLayout(null);
		
		JLabel lblNewLabel_2 = new JLabel("");
		lblNewLabel_2.setIcon(new ImageIcon("C:\\Users\\Shubham\\eclipse-workspace\\mess_management\\alldocument\\112.png"));
		lblNewLabel_2.setBounds(44, 0, 125, 124);
		panel_1.add(lblNewLabel_2);
		
		JLabel lblNewLabel_3 = new JLabel("");
		lblNewLabel_3.setIcon(new ImageIcon("C:\\Users\\Shubham\\eclipse-workspace\\mess_management\\alldocument\\1234.png"));
		lblNewLabel_3.setBounds(54, 147, 104, 140);
		panel_1.add(lblNewLabel_3);
		
		JLabel lblNewLabel_4 = new JLabel("");
		lblNewLabel_4.setIcon(new ImageIcon("C:\\Users\\Shubham\\eclipse-workspace\\mess_management\\alldocument\\12.png"));
		lblNewLabel_4.setBounds(44, 317, 100, 124);
		panel_1.add(lblNewLabel_4);
		
		JLabel lblNewLabel_5 = new JLabel("Member Info");
		lblNewLabel_5.setFont(new Font("Times New Roman", Font.BOLD, 17));
		lblNewLabel_5.setBounds(54, 123, 115, 31);
		panel_1.add(lblNewLabel_5);
		
		JLabel lblNewLabel_6 = new JLabel("Show All Detail");
		lblNewLabel_6.setFont(new Font("Times New Roman", Font.BOLD, 17));
		lblNewLabel_6.setBounds(44, 280, 125, 31);
		panel_1.add(lblNewLabel_6);
		
		JLabel lblNewLabel_7 = new JLabel("Book Thali");
		lblNewLabel_7.setFont(new Font("Times New Roman", Font.BOLD, 17));
		lblNewLabel_7.setBounds(54, 432, 104, 31);
		panel_1.add(lblNewLabel_7);
		
		JButton btnNewButton = new JButton("Exit");
		btnNewButton.setForeground(new Color(0, 0, 0));
		btnNewButton.setBackground(Color.BLACK);
		btnNewButton.setFont(new Font("Times New Roman", Font.BOLD, 14));
		btnNewButton.setBounds(10, 488, 187, 31);
		panel_1.add(btnNewButton);
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			}
		});
		
		JPanel panel_2 = new JPanel();
		panel_2.setBounds(292, 55, 578, 528);
		frame.getContentPane().add(panel_2);
		panel_2.setLayout(null);
		
		JLabel lblNewLabel = new JLabel("");
		lblNewLabel.setBounds(0, 0, 578, 530);
		panel_2.add(lblNewLabel);
		lblNewLabel.setIcon(new ImageIcon("C:\\Users\\Shubham\\eclipse-workspace\\mess_management\\alldocument\\1.jpg"));
		ImageIcon img=new ImageIcon(this.getClass().getResource("/112.jpg"));
	}
}
