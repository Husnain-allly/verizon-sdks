/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.exceptions;

import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonSetter;
import com.verizon.m5gedge.models.OauthProviderError;
import io.apimatic.coreinterfaces.http.Context;

/**
 * This is a model class for OauthProviderException type.
 */
public class OauthProviderException extends ApiException {
    private static final long serialVersionUID = 3585874428095013828L;
    private OauthProviderError error;
    private String errorDescription;
    private String errorUri;

    /**
     * Initialization constructor.
     * @param   reason  The reason for throwing exception
     * @param   context The context of the API exception
     */
    public OauthProviderException(String reason, Context context) {
        super(reason, context);
    }


    /**
     * Getter for Error.
     * Gets or sets error code.
     * @return Returns the OauthProviderError
     */
    @JsonGetter("error")
    public OauthProviderError getError() {
        return this.error;
    }

    /**
     * Setter for Error.
     * Gets or sets error code.
     * @param error Value for OauthProviderError
     */
    @JsonSetter("error")
    private void setError(OauthProviderError error) {
        this.error = error;
    }

    /**
     * Getter for ErrorDescription.
     * Gets or sets human-readable text providing additional information on error. Used to assist
     * the client developer in understanding the error that occurred.
     * @return Returns the String
     */
    @JsonGetter("error_description")
    public String getErrorDescription() {
        return this.errorDescription;
    }

    /**
     * Setter for ErrorDescription.
     * Gets or sets human-readable text providing additional information on error. Used to assist
     * the client developer in understanding the error that occurred.
     * @param errorDescription Value for String
     */
    @JsonSetter("error_description")
    private void setErrorDescription(String errorDescription) {
        this.errorDescription = errorDescription;
    }

    /**
     * Getter for ErrorUri.
     * Gets or sets a URI identifying a human-readable web page with information about the error,
     * used to provide the client developer with additional information about the error.
     * @return Returns the String
     */
    @JsonGetter("error_uri")
    public String getErrorUri() {
        return this.errorUri;
    }

    /**
     * Setter for ErrorUri.
     * Gets or sets a URI identifying a human-readable web page with information about the error,
     * used to provide the client developer with additional information about the error.
     * @param errorUri Value for String
     */
    @JsonSetter("error_uri")
    private void setErrorUri(String errorUri) {
        this.errorUri = errorUri;
    }

    /**
     * Converts this OauthProviderException into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "OauthProviderException [" + "statusCode=" + getResponseCode() + ", message="
                + getMessage() + ", error=" + error + ", errorDescription=" + errorDescription
                + ", errorUri=" + errorUri + "]";
    }
}
