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
 * This is a model class for CallbackRegistrationRequest type.
 */
public class CallbackRegistrationRequest {
    private String accountName;
    private String serviceName;
    private String endpoint;
    private Object httpHeaders;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public CallbackRegistrationRequest() {
    }

    /**
     * Initialization constructor.
     * @param  accountName  String value for accountName.
     * @param  serviceName  String value for serviceName.
     * @param  endpoint  String value for endpoint.
     * @param  httpHeaders  Object value for httpHeaders.
     */
    public CallbackRegistrationRequest(
            String accountName,
            String serviceName,
            String endpoint,
            Object httpHeaders) {
        this.accountName = accountName;
        this.serviceName = serviceName;
        this.endpoint = endpoint;
        this.httpHeaders = httpHeaders;
    }

    /**
     * Getter for AccountName.
     * The name of the billing account for which callback messages will be sent. Format:
     * "##########-#####".
     * @return Returns the String
     */
    @JsonGetter("accountName")
    public String getAccountName() {
        return accountName;
    }

    /**
     * Setter for AccountName.
     * The name of the billing account for which callback messages will be sent. Format:
     * "##########-#####".
     * @param accountName Value for String
     */
    @JsonSetter("accountName")
    public void setAccountName(String accountName) {
        this.accountName = accountName;
    }

    /**
     * Getter for ServiceName.
     * The name of the callback service, which identifies the type and format of messages that will
     * be sent to the registered URL.
     * @return Returns the String
     */
    @JsonGetter("serviceName")
    public String getServiceName() {
        return serviceName;
    }

    /**
     * Setter for ServiceName.
     * The name of the callback service, which identifies the type and format of messages that will
     * be sent to the registered URL.
     * @param serviceName Value for String
     */
    @JsonSetter("serviceName")
    public void setServiceName(String serviceName) {
        this.serviceName = serviceName;
    }

    /**
     * Getter for Endpoint.
     * The URL for your web server.
     * @return Returns the String
     */
    @JsonGetter("endpoint")
    public String getEndpoint() {
        return endpoint;
    }

    /**
     * Setter for Endpoint.
     * The URL for your web server.
     * @param endpoint Value for String
     */
    @JsonSetter("endpoint")
    public void setEndpoint(String endpoint) {
        this.endpoint = endpoint;
    }

    /**
     * Getter for HttpHeaders.
     * Your HTTP headers.
     * @return Returns the Object
     */
    @JsonGetter("httpHeaders")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public Object getHttpHeaders() {
        return httpHeaders;
    }

    /**
     * Setter for HttpHeaders.
     * Your HTTP headers.
     * @param httpHeaders Value for Object
     */
    @JsonSetter("httpHeaders")
    public void setHttpHeaders(Object httpHeaders) {
        this.httpHeaders = httpHeaders;
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
     * Converts this CallbackRegistrationRequest into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "CallbackRegistrationRequest [" + "accountName=" + accountName + ", serviceName="
                + serviceName + ", endpoint=" + endpoint + ", httpHeaders=" + httpHeaders
                + ", additionalProperties=" + additionalProperties + "]";
    }

    /**
     * Builds a new {@link CallbackRegistrationRequest.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link CallbackRegistrationRequest.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(accountName, serviceName, endpoint)
                .httpHeaders(getHttpHeaders());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link CallbackRegistrationRequest}.
     */
    public static class Builder {
        private String accountName;
        private String serviceName;
        private String endpoint;
        private Object httpHeaders;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();

        /**
         * Initialization constructor.
         */
        public Builder() {
        }

        /**
         * Initialization constructor.
         * @param  accountName  String value for accountName.
         * @param  serviceName  String value for serviceName.
         * @param  endpoint  String value for endpoint.
         */
        public Builder(String accountName, String serviceName, String endpoint) {
            this.accountName = accountName;
            this.serviceName = serviceName;
            this.endpoint = endpoint;
        }

        /**
         * Setter for accountName.
         * @param  accountName  String value for accountName.
         * @return Builder
         */
        public Builder accountName(String accountName) {
            this.accountName = accountName;
            return this;
        }

        /**
         * Setter for serviceName.
         * @param  serviceName  String value for serviceName.
         * @return Builder
         */
        public Builder serviceName(String serviceName) {
            this.serviceName = serviceName;
            return this;
        }

        /**
         * Setter for endpoint.
         * @param  endpoint  String value for endpoint.
         * @return Builder
         */
        public Builder endpoint(String endpoint) {
            this.endpoint = endpoint;
            return this;
        }

        /**
         * Setter for httpHeaders.
         * @param  httpHeaders  Object value for httpHeaders.
         * @return Builder
         */
        public Builder httpHeaders(Object httpHeaders) {
            this.httpHeaders = httpHeaders;
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
         * Builds a new {@link CallbackRegistrationRequest} object using the set fields.
         * @return {@link CallbackRegistrationRequest}
         */
        public CallbackRegistrationRequest build() {
            CallbackRegistrationRequest model =
                    new CallbackRegistrationRequest(accountName, serviceName, endpoint,
                            httpHeaders);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
