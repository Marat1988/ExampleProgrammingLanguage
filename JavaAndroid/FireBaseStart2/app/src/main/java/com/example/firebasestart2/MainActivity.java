package com.example.firebasestart2;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.util.Log;
import android.widget.Toast;

import com.google.android.gms.tasks.OnCompleteListener;
import com.google.android.gms.tasks.OnFailureListener;
import com.google.android.gms.tasks.OnSuccessListener;
import com.google.android.gms.tasks.Task;
import com.google.firebase.firestore.DocumentReference;
import com.google.firebase.firestore.EventListener;
import com.google.firebase.firestore.FirebaseFirestore;
import com.google.firebase.firestore.FirebaseFirestoreException;
import com.google.firebase.firestore.QueryDocumentSnapshot;
import com.google.firebase.firestore.QuerySnapshot;

import java.util.HashMap;
import java.util.Map;

import javax.annotation.Nullable;

public class MainActivity extends AppCompatActivity {

    private FirebaseFirestore db;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        db = FirebaseFirestore.getInstance();

//        Map<String, Object> user = new HashMap<>();
//        user.put("name", "Иван");
//        user.put("lastname", "Иванов");
//        user.put("age", 15);
//
//        db.collection("users").add(user)
//                .addOnSuccessListener(new OnSuccessListener<DocumentReference>() {
//                    @Override
//                    public void onSuccess(DocumentReference documentReference) {
//                        Toast.makeText(MainActivity.this, "Success", Toast.LENGTH_SHORT).show();
//                    }
//                })
//                .addOnFailureListener(new OnFailureListener() {
//                    @Override
//                    public void onFailure(@NonNull Exception e) {
//                        Toast.makeText(MainActivity.this, "Error", Toast.LENGTH_SHORT).show();
//                    }
//                });

//        db.collection("users").get()
//                .addOnCompleteListener(new OnCompleteListener<QuerySnapshot>() {
//                    @Override
//                    public void onComplete(@NonNull Task<QuerySnapshot> task) {
//                        if (task.isSuccessful()) {
//                            Toast.makeText(MainActivity.this, "Success", Toast.LENGTH_SHORT).show();
//                            QuerySnapshot querySnapshot = task.getResult();
//                            if (querySnapshot == null) {
//                                return;
//                            }
//                            for (QueryDocumentSnapshot documentSnapshots : querySnapshot) {
//                                Map<String, Object> user = documentSnapshots.getData();
//                                Log.i("FirestoreTest", user.get("name").toString());
//                                Log.i("FirestoreTest", user.get("lastname").toString());
//                                Log.i("FirestoreTest", user.get("age").toString());
//                            }
//                        } else {
//                            Toast.makeText(MainActivity.this, "Error: " + task.getException(), Toast.LENGTH_SHORT).show();
//                        }
//                    }
//                });
        db.collection("users")
                .addSnapshotListener(new EventListener<QuerySnapshot>() {
                    @Override
                    public void onEvent(@Nullable QuerySnapshot queryDocumentSnapshots, @Nullable FirebaseFirestoreException e) {
                        if (queryDocumentSnapshots != null) {
                            for (QueryDocumentSnapshot documentSnapshots : queryDocumentSnapshots) {
                                Map<String, Object> user = documentSnapshots.getData();
                                Log.i("FirestoreTest", user.get("name").toString());
                                Log.i("FirestoreTest", user.get("lastname").toString());
                                Log.i("FirestoreTest", user.get("age").toString());
                            }
                        } else {
                            Toast.makeText(MainActivity.this, "queryDocumentSnapshots is null", Toast.LENGTH_SHORT).show();
                        }
                    }
                });
    }
}
