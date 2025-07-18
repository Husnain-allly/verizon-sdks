/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.models;

import com.fasterxml.jackson.annotation.JsonAnyGetter;
import com.fasterxml.jackson.annotation.JsonAnySetter;
import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonSetter;
import io.apimatic.core.types.AdditionalProperties;
import io.apimatic.core.utilities.ConversionHelper;
import java.util.Map;

/**
 * This is a model class for ApiResponseCode type.
 */
public class ApiResponseCode {
    private ResponseCode responseCode;
    private String message;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public ApiResponseCode() {
    }

    /**
     * Initialization constructor.
     * @param  responseCode  ResponseCode value for responseCode.
     * @param  message  String value for message.
     */
    public ApiResponseCode(
            ResponseCode responseCode,
            String message) {
        this.responseCode = responseCode;
        this.message = message;
    }

    /**
     * Getter for ResponseCode.
     * Possible response codes.
     * @return Returns the ResponseCode
     */
    @JsonGetter("responseCode")
    public ResponseCode getResponseCode() {
        return responseCode;
    }

    /**
     * Setter for ResponseCode.
     * Possible response codes.
     * @param responseCode Value for ResponseCode
     */
    @JsonSetter("responseCode")
    public void setResponseCode(ResponseCode responseCode) {
        this.responseCode = responseCode;
    }

    /**
     * Getter for Message.
     * More details about the responseCode received.
     * @return Returns the String
     */
    @JsonGetter("message")
    public String getMessage() {
        return message;
    }

    /**
     * Setter for Message.
     * More details about the responseCode received.
     * @param message Value for String
     */
    @JsonSetter("message")
    public void setMessage(String message) {
        this.message = message;
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
     * Converts this ApiResponseCode into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "ApiResponseCode [" + "responseCode=" + responseCode + ", message=" + message
                + ", additionalProperties=" + additionalProperties + "]";
    }

    /**
     * Builds a new {@link ApiResponseCode.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link ApiResponseCode.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(responseCode, message);
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link ApiResponseCode}.
     */
    public static class Builder {
        private ResponseCode responseCode;
        private String message;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();

        /**
         * Initialization constructor.
         */
        public Builder() {
        }

        /**
         * Initialization constructor.
         * @param  responseCode  ResponseCode value for responseCode.
         * @param  message  String value for message.
         */
        public Builder(ResponseCode responseCode, String message) {
            this.responseCode = responseCode;
            this.message = message;
        }

        /**
         * Setter for responseCode.
         * @param  responseCode  ResponseCode value for responseCode.
         * @return Builder
         */
        public Builder responseCode(ResponseCode responseCode) {
            this.responseCode = responseCode;
            return this;
        }

        /**
         * Setter for message.
         * @param  message  String value for message.
         * @return Builder
         */
        public Builder message(String message) {
            this.message = message;
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
         * Builds a new {@link ApiResponseCode} object using the set fields.
         * @return {@link ApiResponseCode}
         */
        public ApiResponseCode build() {
            ApiResponseCode model =
                    new ApiResponseCode(responseCode, message);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
