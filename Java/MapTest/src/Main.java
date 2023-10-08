import java.util.*;

public class Main {
    public static void main(String[] args) {
        ArrayList<Map<String, Object>> users = new ArrayList<>();

        for (int i = 0; i < 50; i++) {
            Map<String, Object> user = new HashMap<>();
            user.put("name", "Иван " + i);
            user.put("lastname", "Иванов " + i);
            user.put("age", 15);
            users.add(user);
        }

        for (Map<String, Object> user : users) {
            for (String key : user.keySet()) {
                System.out.println(user.get(key));
            }
        }


    }
}