package FileIO;

import java.lang.*;
import java.io.*;

public class FileIO {
    private File file;
    private FileWriter writer;
    private FileReader reader;
    private BufferedReader bfr;
    public FileIO(){
        file = new File("History.txt");
        if (file.exists())
            file.delete();
        try{file.createNewFile();}
        catch(Exception e){System.out.println("Error occured while creating file.");}
    }
    public void writeInFile(String s) {
        try {
            writer = new FileWriter(file, true);
            writer.write(s + "\r" + "\n");
            writer.flush();
            writer.close();
        } catch (IOException ioe) {
            ioe.printStackTrace();
        }
    }

    public void readFromFile() {
        try {
            reader = new FileReader(file);
            bfr = new BufferedReader(reader);
            String text = "", temp;

            while ((temp = bfr.readLine()) != null) {
                text = text + temp + "\n" + "\r";
            }

            System.out.println(text);
            reader.close();
        } catch (IOException ioe) {
            ioe.printStackTrace();
        }
    }
}