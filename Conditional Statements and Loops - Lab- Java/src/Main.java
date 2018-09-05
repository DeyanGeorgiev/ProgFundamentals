import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int hour = Integer.parseInt(in.nextLine());
        int min= Integer.parseInt(in.nextLine());


        if ( hour>=0 && hour <=23 && min >= 0 && min <=59){


            int checkHour= hour+1;
            int checkMin= min+30;

            int resultMin= 0;
            int resultHour= 0;


            if (checkMin> 59){

                resultMin= checkMin-60;
                resultHour= hour+ 1;


            } else{

                resultMin= min+ 30;
                resultHour= hour;
            }



            if ( checkHour> 23 || hour==0){

                if (checkMin> 59){

                    resultMin= checkMin-60;
                    resultHour= 0;


                } else{

                    resultMin= min+ 30;
                    resultHour= 0;
                }


            }

            System.out.printf("%2d:%02d", resultHour, resultMin);








        }



    }
}
