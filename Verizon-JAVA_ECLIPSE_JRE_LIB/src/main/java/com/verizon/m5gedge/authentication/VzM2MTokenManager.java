/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.authentication;

import io.apimatic.core.authentication.HeaderAuth;
import java.util.HashMap;

public class VzM2MTokenManager extends HeaderAuth implements VzM2MTokenCredentials {

    /**
     * Private instance of the auth model containing the auth credentials.
     */
    private VzM2MTokenModel authModel;

    /**
     * Constructor that sets custom header parameters.
     */
    public VzM2MTokenManager(VzM2MTokenModel authModel) {

        super(new HashMap<String,String>() {
            private static final long serialVersionUID = 1L;
            {
                put("VZ-M2M-Token", authModel.getVzM2MToken());
            }
        });

        this.authModel = authModel;
    }

    /**
     * String value for vzM2MToken.
     * @return vzM2MToken
     */
    public String getVzM2MToken() {
        return authModel.getVzM2MToken();
    }

    /**
     * Checks if provided credentials matched with existing ones.
     * @param vzM2MToken String value for credentials.
     * @return true if credentials matched.
     */
    public boolean equals(String vzM2MToken) {
        return vzM2MToken.equals(getVzM2MToken());
    }

    /**
     * Converts this VzM2MTokenManager into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "VzM2MTokenManager [" + "vzM2MToken=" + getVzM2MToken() + "]";
    }
    /**
    * Returns the error message if the auth credentials are not valid.
    * @return the auth specific error message.
    */
    @Override
    public String getErrorMessage() {
        String errorMessage = super.getErrorMessage();
        if (errorMessage == null) {
            return null;
        }

        return "VzM2MToken - " + errorMessage;
    }

}
