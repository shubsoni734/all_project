package mess_management;

import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.ImageIcon;
import java.awt.Color;
import java.awt.Font;
import java.awt.SystemColor;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.util.Calendar;
import java.util.GregorianCalendar;
import java.awt.event.ActionEvent;

public class Main_menu {

	private JFrame frame;
	private JLabel lbltime;
	private JLabel lblday;

	/**
	 * Launch the application.
	 */
	public static void Newscreen() {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Main_menu window = new Main_menu();
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
					for(;;) {
					Calendar cal=new GregorianCalendar();
					int day=cal.get(Calendar.DAY_OF_MONTH);
					int month=cal.get(Calendar.MONTH);
					int year=cal.get(Calendar.YEAR);
					
					int hour=cal.get(Calendar.HOUR);
					int minuet=cal.get(Calendar.MINUTE);
					int secound=cal.get(Calendar.SECOND);
					 
					lbltime.setText("Time  "+hour+":"+minuet+":"+secound);
					lblday.setText("Date "+day+"/"+month+"/"+year);
					
					sleep(1000);
					}
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
	public Main_menu() {
		initialize();
		clock();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.getContentPane().setBackground(Color.GRAY);
		frame.setBounds(100, 100, 812, 581);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		JPanel panel = new JPanel();
		panel.setBackground(new Color(153, 102, 153));
		panel.setBounds(0, 0, 796, 59);
		frame.getContentPane().add(panel);
		panel.setLayout(null);
		
		JLabel lblNewLabel_1 = new JLabel("Mess Management System");
		lblNewLabel_1.setForeground(new Color(0, 0, 255));
		lblNewLabel_1.setBounds(236, 11, 330, 37);
		lblNewLabel_1.setFont(new Font("Times New Roman", Font.BOLD, 27));
		panel.add(lblNewLabel_1);
		
		lbltime = new JLabel("New label");
		lbltime.setForeground(new Color(0, 255, 255));
		lbltime.setBounds(675, 11, 111, 24);
		panel.add(lbltime);
		
		lblday = new JLabel("New label");
		lblday.setForeground(new Color(0, 255, 255));
		lblday.setBounds(675, 34, 111, 25);
		panel.add(lblday);
		
		JPanel panel_1 = new JPanel();
		panel_1.setBackground(SystemColor.activeCaption);
		panel_1.setBounds(0, 57, 219, 486);
		frame.getContentPane().add(panel_1);
		panel_1.setLayout(null);
		
		JLabel lblNewLabel_2 = new JLabel("");
		lblNewLabel_2.setIcon(new ImageIcon("C:\\Users\\Shubham\\Downloads\\1370398972253981498business_user_add-1-th.png"));
		lblNewLabel_2.setBounds(52, 11, 101, 103);
		panel_1.add(lblNewLabel_2);
		
		JLabel lblNewLabel_3 = new JLabel("Add Member");
		lblNewLabel_3.setFont(new Font("Times New Roman", Font.BOLD, 15));
		lblNewLabel_3.setForeground(Color.BLACK);
		lblNewLabel_3.setBounds(51, 114, 91, 25);
		panel_1.add(lblNewLabel_3);
		
		JLabel lblNewLabel_4 = new JLabel("");
		lblNewLabel_4.setIcon(new ImageIcon("C:\\Users\\Shubham\\Downloads\\clipart2240130.png"));
		lblNewLabel_4.setBounds(52, 150, 112, 139);
		panel_1.add(lblNewLabel_4);
		
		JLabel lblNewLabel_5 = new JLabel("Show All Detail");
		lblNewLabel_5.setFont(new Font("Times New Roman", Font.BOLD, 15));
		lblNewLabel_5.setForeground(Color.BLACK);
		lblNewLabel_5.setBounds(51, 294, 102, 25);
		panel_1.add(lblNewLabel_5);
		
		JLabel lblNewLabel_6 = new JLabel("");
		lblNewLabel_6.setIcon(new ImageIcon("C:\\Users\\Shubham\\eclipse-workspace\\mess_management\\alldocument\\12.png"));
		lblNewLabel_6.setBounds(52, 317, 102, 103);
		panel_1.add(lblNewLabel_6);
		
		JLabel lblNewLabel_7 = new JLabel("Book Thali");
		lblNewLabel_7.setFont(new Font("Times New Roman", Font.BOLD, 15));
		lblNewLabel_7.setForeground(Color.BLACK);
		lblNewLabel_7.setBounds(76, 414, 91, 25);
		panel_1.add(lblNewLabel_7);
		
		JButton btnNewButton = new JButton("Exit");
		btnNewButton.setBackground(new Color(102, 205, 170));
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				JFrame frame=new JFrame("Exit");
				if(JOptionPane.showConfirmDialog(frame, "Confirm if you want to Exit","Exit",JOptionPane.YES_NO_OPTION)==JOptionPane.YES_NO_OPTION) {
					System.exit(0);
				}
			}
		});
		btnNewButton.setFont(new Font("Times New Roman", Font.BOLD, 14));
		btnNewButton.setBounds(124, 450, 85, 25);
		panel_1.add(btnNewButton);
		
		JButton btnLoginPage = new JButton("Back");
		btnLoginPage.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				login_page nw=new login_page();
				nw.main(null);
				JFrame frame=new JFrame("Exit");
			}
		});
		btnLoginPage.setBackground(new Color(102, 205, 170));
		btnLoginPage.setFont(new Font("Times New Roman", Font.BOLD, 14));
		btnLoginPage.setBounds(10, 450, 85, 25);
		panel_1.add(btnLoginPage);
		
		JLabel lblNewLabel = new JLabel("");
		lblNewLabel.setIcon(new ImageIcon("C:\\Users\\Shubham\\eclipse-workspace\\mess_management\\alldocument\\1.jpg"));
		lblNewLabel.setBounds(229, 57, 557, 486);
		frame.getContentPane().add(lblNewLabel);
	}
	public Object getFrame() {
		// TODO Auto-generated method stub
		return null;
	}
}
