string address1 = @"D:\b.bab";

StreamReader srreader = new StreamReader(address1); 

string text = srreader.ReadToEnd();
Console.WriteLine(text);
text = text + "\n 4068771\t2533490\t67627\t51:02.0\t133028\tتهران\t1\r\n";
text = text + "\n 9916301\t1145709\t102588\t33:59.0\t34862\tتهران\t1\r\n";
text = text + "\n 4605740\t637880\t138296\t48:18.0\t469358\tتهران\t1\r\n";
text = text + "\n 13469523\t3819595\t564993\t28:55.0\t525000\tتهران\t1\r\n";
text = text + "\n 24233238\t500391\t1707686\t44:36.0\t49000\tتهران\t1\r\n";
text = text + "\n 4851441\t3105577\t183721\t27:44.0\t23853\tتهران\t1\r\n";
text = text + "\n 23062506\t7193109\t1656648\t48:12.0\t229000\tتهران\t2\r\n";
srreader.Close();

string address2 = @"D:t.txt";

StreamReader srwriter = new StreamReader(address2);
Console.WriteLine(text);
text = text + "\n 8267421\t5235886\t42365\t30:24.0\t55046\tاصفهان\t1\r\n";
text = text + "\n 7759076\t3185842\t376625\t37:45.0\t708440\tاصفهان\t1\r\n";
text = text + "\n 9503051\t3048383\t449799\t05:08.0\t20000\tاصفهان\t1\r\n";
text = text + "\n 12098630\t496463\t757921\t42:40.0\t641284\tاصفهان\t1\r\n";
text = text + "\n 2660956\t789236\t33118\t56:56.0\t13761\tاصفهان\t1\r\n";
text = text + "\n 9968607\t6056601\t311668\t32:25.0\t128440\tاصفهان\t1\r\n";
srwriter.Close();