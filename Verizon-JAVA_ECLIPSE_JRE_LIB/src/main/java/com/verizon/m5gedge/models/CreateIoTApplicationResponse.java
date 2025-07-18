/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.models;

import com.fasterxml.jackson.annotation.JsonAnyGetter;
import com.fasterxml.jackson.annotation.JsonAnySetter;
import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonSetter;
import io.apimatic.core.types.AdditionalProperties;
import io.apimatic.core.utilities.ConversionHelper;
import java.util.Map;

/**
 * This is a model class for CreateIoTApplicationResponse type.
 */
public class CreateIoTApplicationResponse {
    private String appName;
    private String sharedSecret;
    private String url;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public CreateIoTApplicationResponse() {
    }

    /**
     * Initialization constructor.
     * @param  appName  String value for appName.
     * @param  sharedSecret  String value for sharedSecret.
     * @param  url  String value for url.
     */
    public CreateIoTApplicationResponse(
            String appName,
            String sharedSecret,
            String url) {
        this.appName = appName;
        this.sharedSecret = sharedSecret;
        this.url = url;
    }

    /**
     * Getter for AppName.
     * An application will be created under the user's Azure subscription with this name and of type
     * IOT central.
     * @return Returns the String
     */
    @JsonGetter("appName")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getAppName() {
        return appName;
    }

    /**
     * Setter for AppName.
     * An application will be created under the user's Azure subscription with this name and of type
     * IOT central.
     * @param appName Value for String
     */
    @JsonSetter("appName")
    public void setAppName(String appName) {
        this.appName = appName;
    }

    /**
     * Getter for SharedSecret.
     * Part of the user credentials (from Azure) the user needs to use for calling further TS Core
     * APIs for setting up Azure cloud connector.
     * @return Returns the String
     */
    @JsonGetter("sharedSecret")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getSharedSecret() {
        return sharedSecret;
    }

    /**
     * Setter for SharedSecret.
     * Part of the user credentials (from Azure) the user needs to use for calling further TS Core
     * APIs for setting up Azure cloud connector.
     * @param sharedSecret Value for String
     */
    @JsonSetter("sharedSecret")
    public void setSharedSecret(String sharedSecret) {
        this.sharedSecret = sharedSecret;
    }

    /**
     * Getter for Url.
     * An IOT central endpoint the user can use to see the data that is being streamed.
     * @return Returns the String
     */
    @JsonGetter("url")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getUrl() {
        return url;
    }

    /**
     * Setter for Url.
     * An IOT central endpoint the user can use to see the data that is being streamed.
     * @param url Value for String
     */
    @JsonSetter("url")
    public void setUrl(String url) {
        this.url = url;
    }

    /**
     * Hidden method for the serialization of additional properties.
     * @return The map of additionally set properties.
     */
    @JsonAnyGetter
    private Map<String, Object> getAdditionalProperties() {
        return additionalProperties.getAdditionalProperties();
    }

    /**
     * Hidden method for the de-serialization of additional properties.
     * @param name The name of the additional property.
     * @param value The Object value of the additional property.
     */
    @JsonAnySetter
    private void setAdditionalProperties(String name, Object value) {
        additionalProperties.setAdditionalProperty(name,
                ConversionHelper.convertToSimpleType(value,
                        x -> x),
                true);
    }

    /**
     * Getter for the value of additional properties based on provided property name.
     * @param name The name of the additional property.
     * @return Either the Object property value or null if not exist.
     */
    
    public Object getAdditionalProperty(String name) {
        return additionalProperties.getAdditionalProperty(name);
    }

    /**
     * Converts this CreateIoTApplicationResponse into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "CreateIoTApplicationResponse [" + "appName=" + appName + ", sharedSecret="
                + sharedSecret + ", url=" + url + ", additionalProperties=" + additionalProperties
                + "]";
    }

    /**
     * Builds a new {@link CreateIoTApplicationResponse.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link CreateIoTApplicationResponse.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .appName(getAppName())
                .sharedSecret(getSharedSecret())
                .url(getUrl());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link CreateIoTApplicationResponse}.
     */
    public static class Builder {
        private String appName;
        private String sharedSecret;
        private String url;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();



        /**
         * Setter for appName.
         * @param  appName  String value for appName.
         * @return Builder
         */
        public Builder appName(String appName) {
            this.appName = appName;
            return this;
        }

        /**
         * Setter for sharedSecret.
         * @param  sharedSecret  String value for sharedSecret.
         * @return Builder
         */
        public Builder sharedSecret(String sharedSecret) {
            this.sharedSecret = sharedSecret;
            return this;
        }

        /**
         * Setter for url.
         * @param  url  String value for url.
         * @return Builder
         */
        public Builder url(String url) {
            this.url = url;
            return this;
        }

        /**
         * Setter for additional property that are not in model fields.
         * @param name The name of the additional property.
         * @param value The Object value of the additional property.
         * @return Builder.
         */
        public Builder additionalProperty(String name, Object value) {
            this.additionalProperties.setAdditionalProperty(name, value);
            return this;
        }

        /**
         * Builds a new {@link CreateIoTApplicationResponse} object using the set fields.
         * @return {@link CreateIoTApplicationResponse}
         */
        public CreateIoTApplicationResponse build() {
            CreateIoTApplicationResponse model =
                    new CreateIoTApplicationResponse(appName, sharedSecret, url);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
