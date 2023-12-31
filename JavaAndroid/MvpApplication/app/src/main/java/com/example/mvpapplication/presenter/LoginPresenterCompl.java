package com.example.mvpapplication.presenter;

import android.os.Handler;
import android.os.Looper;

import com.example.mvpapplication.Model.IUser;
import com.example.mvpapplication.Model.UserModel;
import com.example.mvpapplication.view.ILoginView;

public class LoginPresenterCompl implements ILoginPresenter{
    ILoginView iLoginView;
    IUser user;
    Handler handler;

    public LoginPresenterCompl(ILoginView iLoginView) {
        this.iLoginView = iLoginView;
        initUser();
        handler = new Handler(Looper.getMainLooper());

    }

    @Override
    public void clear() {
        iLoginView.onClearText();
    }

    @Override
    public void doLogin(String name, String passwd) {
        Boolean osLoginSuccess = true;
        final int code = user.checkUserValidity(name, passwd);
        if (code!=0) isLoginSuccess = false;
        handler.postDelayed(new Runnable() {
            @Override
            public void run() {
                iLoginView.onLoginResult(result, code);
            }
        },5000);
    }

    @Override
    public void setProgressBarVisiblity(int visiblity) {
        iLoginView.onSetProgressBarVisibility(visiblity);
    }

    private void initUser(){
        user = new UserModel("mvp","mvp");
    }
}
