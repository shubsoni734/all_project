package mess_management;

import java.awt.EventQueue;

import javax.swing.JFrame;
import java.awt.Color;
import javax.swing.JPanel;
import javax.swing.JLabel;
import java.awt.Font;
import javax.swing.JTextField;
import javax.swing.JList;
import javax.swing.JOptionPane;
import javax.swing.JComboBox;
import javax.swing.DefaultComboBoxModel;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Add_member {

	private JFrame frame;
	private JTextField txtname;
	private JTextField txtmob;
	private JTextField txtcom;
	private JTextField txtamt;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Add_member window = new Add_member();
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
	public Add_member() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.getContentPane().setBackground(Color.ORANGE);
		frame.setBounds(100, 100, 798, 517);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		JPanel panel = new JPanel();
		panel.setBackground(new Color(0, 204, 204));
		panel.setBounds(10, 11, 762, 50);
		frame.getContentPane().add(panel);
		panel.setLayout(null);
		
		JLabel lblNewLabel = new JLabel("Mess Management System");
		lblNewLabel.setFont(new Font("Times New Roman", Font.BOLD, 27));
		lblNewLabel.setBounds(192, 0, 330, 39);
		panel.add(lblNewLabel);
		
		JPanel panel_1 = new JPanel();
		panel_1.setBackground(new Color(0, 153, 204));
		panel_1.setBounds(10, 59, 762, 409);
		frame.getContentPane().add(panel_1);
		panel_1.setLayout(null);
		
		JLabel lblNewLabel_1 = new JLabel("Name :");
		lblNewLabel_1.setFont(new Font("Traditional Arabic", Font.BOLD, 16));
		lblNewLabel_1.setBounds(178, 61, 89, 25);
		panel_1.add(lblNewLabel_1);
		
		JLabel lblNewLabel_1_1 = new JLabel("Mobile No. :");
		lblNewLabel_1_1.setFont(new Font("Traditional Arabic", Font.BOLD, 16));
		lblNewLabel_1_1.setBounds(178, 97, 89, 25);
		panel_1.add(lblNewLabel_1_1);
		
		JLabel lblNewLabel_1_3 = new JLabel("Companey Name :");
		lblNewLabel_1_3.setFont(new Font("Traditional Arabic", Font.BOLD, 16));
		lblNewLabel_1_3.setBounds(178, 133, 139, 25);
		panel_1.add(lblNewLabel_1_3);
		
		JLabel lblNewLabel_1_4 = new JLabel("Thali Type :");
		lblNewLabel_1_4.setFont(new Font("Traditional Arabic", Font.BOLD, 16));
		lblNewLabel_1_4.setBounds(178, 169, 127, 25);
		panel_1.add(lblNewLabel_1_4);
		
		JLabel lblNewLabel_1_5 = new JLabel("Amount Paid :");
		lblNewLabel_1_5.setFont(new Font("Traditional Arabic", Font.BOLD, 16));
		lblNewLabel_1_5.setBounds(178, 241, 139, 25);
		panel_1.add(lblNewLabel_1_5);
		
		JLabel lblNewLabel_1_6 = new JLabel("Name");
		lblNewLabel_1_6.setFont(new Font("Times New Roman", Font.BOLD, 16));
		lblNewLabel_1_6.setBounds(390, 277, 89, 25);
		panel_1.add(lblNewLabel_1_6);
		
		JLabel lblNewLabel_1_7 = new JLabel("Total Amount :");
		lblNewLabel_1_7.setFont(new Font("Traditional Arabic", Font.BOLD, 16));
		lblNewLabel_1_7.setBounds(178, 277, 114, 25);
		panel_1.add(lblNewLabel_1_7);
		
		JLabel lblNewLabel_1_4_1 = new JLabel("Thali day :");
		lblNewLabel_1_4_1.setFont(new Font("Traditional Arabic", Font.BOLD, 16));
		lblNewLabel_1_4_1.setBounds(178, 205, 89, 25);
		panel_1.add(lblNewLabel_1_4_1);
		
		txtname = new JTextField();
		txtname.setBounds(378, 61, 186, 25);
		panel_1.add(txtname);
		txtname.setColumns(10);
		
		txtmob = new JTextField();
		txtmob.setColumns(10);
		txtmob.setBounds(380, 99, 186, 25);
		panel_1.add(txtmob);
		
		txtcom = new JTextField();
		txtcom.setColumns(10);
		txtcom.setBounds(378, 135, 186, 25);
		panel_1.add(txtcom);
		
		txtamt = new JTextField();
		txtamt.setColumns(10);
		txtamt.setBounds(378, 241, 186, 25);
		panel_1.add(txtamt);
		
		JList list = new JList();
		list.setBounds(441, 196, -191, -22);
		panel_1.add(list);
		
		JComboBox cmbthali = new JComboBox();
		cmbthali.setModel(new DefaultComboBoxModel(new String[] {"<select Thali Type>", "Puri Bhaji", "Mess Thali", "Full Thali"}));
		cmbthali.setBounds(378, 170, 186, 25);
		panel_1.add(cmbthali);
		
		JComboBox cmbday = new JComboBox();
		cmbday.setModel(new DefaultComboBoxModel(new String[] {"0", "15", "30", "45", "60"}));
		cmbday.setBounds(378, 206, 186, 22);
		panel_1.add(cmbday);
		
		JLabel lblNewLabel_2 = new JLabel("New label");
		lblNewLabel_2.setFont(new Font("Times New Roman", Font.BOLD, 16));
		lblNewLabel_2.setBounds(390, 312, 89, 25);
		panel_1.add(lblNewLabel_2);
		
		JLabel lblNewLabel_3 = new JLabel("Valid Till :");
		lblNewLabel_3.setFont(new Font("Traditional Arabic", Font.BOLD, 16));
		lblNewLabel_3.setBounds(178, 313, 114, 25);
		panel_1.add(lblNewLabel_3);
		
		JLabel lblNewLabel_4 = new JLabel("Add Member");
		lblNewLabel_4.setIcon(new ImageIcon("D:\\Software\\ICONZ COLLECTION\\ico\\add_user.ico"));
		lblNewLabel_4.setFont(new Font("Traditional Arabic", Font.BOLD, 21));
		lblNewLabel_4.setBounds(286, 11, 139, 39);
		panel_1.add(lblNewLabel_4);
		
		JButton btnNewButton = new JButton("Exit");
		btnNewButton.setBackground(new Color(0, 255, 255));
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				JFrame frame=new JFrame("Exit");
				if(JOptionPane.showConfirmDialog(frame, "Confirm if you want to Exit","Exit",JOptionPane.YES_NO_OPTION)==JOptionPane.YES_NO_OPTION) {
					System.exit(0);
				}
			}
		});
		btnNewButton.setBounds(570, 367, 129, 31);
		panel_1.add(btnNewButton);
		
		JButton btnBack = new JButton("Back");
		btnBack.setBackground(new Color(0, 255, 255));
		btnBack.setBounds(411, 367, 129, 31);
		panel_1.add(btnBack);
		
		JButton btnNewButton_1_1 = new JButton("Save");
		btnNewButton_1_1.setBackground(new Color(0, 255, 255));
		btnNewButton_1_1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			}
		});
		btnNewButton_1_1.setBounds(255, 367, 127, 31);
		panel_1.add(btnNewButton_1_1);
		
		JButton btnNewButton_1_2 = new JButton("Clear");
		btnNewButton_1_2.setBackground(new Color(0, 255, 255));
		btnNewButton_1_2.setBounds(84, 367, 129, 31);
		panel_1.add(btnNewButton_1_2);
		
		JLabel lblNewLabel_5 = new JLabel("New label");
		lblNewLabel_5.setIcon(new ImageIcon("C:\\Users\\Shubham\\eclipse-workspace\\mess_management\\alldocument\\1370398972253981498business_user_add-1-th.png"));
		lblNewLabel_5.setBounds(210, -3, 70, 70);
		panel_1.add(lblNewLabel_5);
	}
}
