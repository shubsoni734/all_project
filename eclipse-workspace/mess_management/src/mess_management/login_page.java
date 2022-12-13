package mess_management;

import java.awt.EventQueue;

import javax.swing.JFrame;
import java.awt.Color;
import javax.swing.JPanel;
import java.awt.SystemColor;
import javax.swing.JTextField;
import javax.swing.JPasswordField;
import javax.swing.JLabel;
import javax.swing.JOptionPane;

import java.awt.Font;
import javax.swing.JButton;
import javax.swing.ImageIcon;
import javax.swing.JSeparator;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;


public class login_page {

	private JFrame frame;
	private JTextField user;
	private JPasswordField pass;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					login_page window = new login_page();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public login_page() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.getContentPane().setBackground(Color.BLACK);
		frame.setBackground(Color.BLACK);
		frame.setBounds(100, 100, 560, 365);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		JPanel panel = new JPanel();
		panel.setBackground(SystemColor.textHighlight);
		panel.setBounds(10, 11, 524, 304);
		frame.getContentPane().add(panel);
		panel.setLayout(null);
		
		JPanel panel_1 = new JPanel();
		panel_1.setBounds(171, 0, 353, 304);
		panel_1.setBackground(SystemColor.activeCaption);
		panel.add(panel_1);
		panel_1.setLayout(null);
		
		user = new JTextField();
		user.setBounds(161, 111, 164, 27);
		panel_1.add(user);
		user.setColumns(10);
		
		pass = new JPasswordField();
		pass.setBounds(161, 160, 164, 27);
		panel_1.add(pass);
		
		JLabel lblNewLabel = new JLabel("USER NAME");
		lblNewLabel.setBounds(29, 109, 100, 27);
		lblNewLabel.setFont(new Font("Tahoma", Font.BOLD, 14));
		panel_1.add(lblNewLabel);
		
		JLabel lblNewLabel_1 = new JLabel("PASSWORD");
		lblNewLabel_1.setBounds(29, 158, 100, 27);
		lblNewLabel_1.setFont(new Font("Tahoma", Font.BOLD, 14));
		lblNewLabel_1.setForeground(new Color(0, 0, 0));
		panel_1.add(lblNewLabel_1);
		
		JLabel lblNewLabel_2 = new JLabel("Admin Login");
		lblNewLabel_2.setBounds(98, 21, 164, 40);
		lblNewLabel_2.setFont(new Font("Times New Roman", Font.BOLD, 21));
		panel_1.add(lblNewLabel_2);
		
		JButton btnreset = new JButton("Reset");
		btnreset.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				user.setText(null);
				pass.setText(null);
			}
		});
		btnreset.setBounds(49, 239, 69, 23);
		btnreset.setFont(new Font("Times New Roman", Font.BOLD, 13));
		panel_1.add(btnreset);
		
		JButton btnlogin = new JButton("Login");
		btnlogin.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				String un=user.getText();
				String ps=pass.getText();
				if(un.contains("admin")&&ps.contains("1234"))
				{
					user.setText(null);
					pass.setText(null);
					
					Main_menu ne=new Main_menu();
					ne.Newscreen();
					var frame=new JFrame("Exit");
					
				}
				else
				{
					JOptionPane.showMessageDialog(null,"Invalid Login Details ","Login Error",JOptionPane.ERROR_MESSAGE);
					user.setText(null);
					pass.setText(null);
				}
			}
		});
		btnlogin.setBounds(148, 239, 69, 23);
		btnlogin.setFont(new Font("Times New Roman", Font.BOLD, 13));
		panel_1.add(btnlogin);
		
		JButton btnclose = new JButton("Exit");
		btnclose.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				JFrame frame=new JFrame("Exit");
				if(JOptionPane.showConfirmDialog(frame, "Confirm if you want to Exit","Exit",JOptionPane.YES_NO_OPTION)==JOptionPane.YES_NO_OPTION) {
					System.exit(0);
				}
			
			}
		});
		btnclose.setBounds(256, 239, 69, 23);
		btnclose.setFont(new Font("Times New Roman", Font.BOLD, 13));
		panel_1.add(btnclose);
		
		JSeparator separator = new JSeparator();
		separator.setBounds(10, 214, 318, -8);
		separator.setBackground(SystemColor.inactiveCaptionText);
		panel_1.add(separator);
		
		JSeparator separator_1 = new JSeparator();
		separator_1.setBackground(new Color(255, 255, 255));
		separator_1.setBounds(30, 215, 295, 2);
		panel_1.add(separator_1);
		
		JSeparator separator_1_1 = new JSeparator();
		separator_1_1.setBackground(Color.WHITE);
		separator_1_1.setBounds(30, 72, 295, 2);
		panel_1.add(separator_1_1);
		
		JPanel panel_2 = new JPanel();
		panel_2.setBackground(SystemColor.inactiveCaptionBorder);
		panel_2.setBounds(0, 0, 171, 304);
		panel.add(panel_2);
		panel_2.setLayout(null);
		
		JLabel lblNewLabel_3 = new JLabel("");
		ImageIcon img=new ImageIcon(this.getClass().getResource("/Capture1.jpg"));
		lblNewLabel_3.setIcon(img);
		lblNewLabel_3.setForeground(SystemColor.activeCaptionBorder);
		lblNewLabel_3.setFont(new Font("Sylfaen", Font.BOLD, 29));
		lblNewLabel_3.setBounds(21, 73, 140, 162);
		panel_2.add(lblNewLabel_3);
		
		JSeparator separator_2 = new JSeparator();
		separator_2.setBounds(171, 217, 1, 2);
		panel_2.add(separator_2);
	}
}
