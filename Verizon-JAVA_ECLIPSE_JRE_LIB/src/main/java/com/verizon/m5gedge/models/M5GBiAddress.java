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
 * This is a model class for M5GBiAddress type.
 */
public class M5GBiAddress {
    private String addressLine1;
    private String city;
    private String state;
    private String zip;
    private String zip4;
    private String phone;
    private String phoneType;
    private String emailAddress;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public M5GBiAddress() {
    }

    /**
     * Initialization constructor.
     * @param  addressLine1  String value for addressLine1.
     * @param  city  String value for city.
     * @param  state  String value for state.
     * @param  zip  String value for zip.
     * @param  zip4  String value for zip4.
     * @param  phone  String value for phone.
     * @param  phoneType  String value for phoneType.
     * @param  emailAddress  String value for emailAddress.
     */
    public M5GBiAddress(
            String addressLine1,
            String city,
            String state,
            String zip,
            String zip4,
            String phone,
            String phoneType,
            String emailAddress) {
        this.addressLine1 = addressLine1;
        this.city = city;
        this.state = state;
        this.zip = zip;
        this.zip4 = zip4;
        this.phone = phone;
        this.phoneType = phoneType;
        this.emailAddress = emailAddress;
    }

    /**
     * Getter for AddressLine1.
     * @return Returns the String
     */
    @JsonGetter("addressLine1")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getAddressLine1() {
        return addressLine1;
    }

    /**
     * Setter for AddressLine1.
     * @param addressLine1 Value for String
     */
    @JsonSetter("addressLine1")
    public void setAddressLine1(String addressLine1) {
        this.addressLine1 = addressLine1;
    }

    /**
     * Getter for City.
     * @return Returns the String
     */
    @JsonGetter("city")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getCity() {
        return city;
    }

    /**
     * Setter for City.
     * @param city Value for String
     */
    @JsonSetter("city")
    public void setCity(String city) {
        this.city = city;
    }

    /**
     * Getter for State.
     * @return Returns the String
     */
    @JsonGetter("state")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getState() {
        return state;
    }

    /**
     * Setter for State.
     * @param state Value for String
     */
    @JsonSetter("state")
    public void setState(String state) {
        this.state = state;
    }

    /**
     * Getter for Zip.
     * @return Returns the String
     */
    @JsonGetter("zip")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getZip() {
        return zip;
    }

    /**
     * Setter for Zip.
     * @param zip Value for String
     */
    @JsonSetter("zip")
    public void setZip(String zip) {
        this.zip = zip;
    }

    /**
     * Getter for Zip4.
     * @return Returns the String
     */
    @JsonGetter("zip+4")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getZip4() {
        return zip4;
    }

    /**
     * Setter for Zip4.
     * @param zip4 Value for String
     */
    @JsonSetter("zip+4")
    public void setZip4(String zip4) {
        this.zip4 = zip4;
    }

    /**
     * Getter for Phone.
     * @return Returns the String
     */
    @JsonGetter("phone")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getPhone() {
        return phone;
    }

    /**
     * Setter for Phone.
     * @param phone Value for String
     */
    @JsonSetter("phone")
    public void setPhone(String phone) {
        this.phone = phone;
    }

    /**
     * Getter for PhoneType.
     * @return Returns the String
     */
    @JsonGetter("phoneType")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getPhoneType() {
        return phoneType;
    }

    /**
     * Setter for PhoneType.
     * @param phoneType Value for String
     */
    @JsonSetter("phoneType")
    public void setPhoneType(String phoneType) {
        this.phoneType = phoneType;
    }

    /**
     * Getter for EmailAddress.
     * @return Returns the String
     */
    @JsonGetter("emailAddress")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getEmailAddress() {
        return emailAddress;
    }

    /**
     * Setter for EmailAddress.
     * @param emailAddress Value for String
     */
    @JsonSetter("emailAddress")
    public void setEmailAddress(String emailAddress) {
        this.emailAddress = emailAddress;
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
     * Converts this M5GBiAddress into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "M5GBiAddress [" + "addressLine1=" + addressLine1 + ", city=" + city + ", state="
                + state + ", zip=" + zip + ", zip4=" + zip4 + ", phone=" + phone + ", phoneType="
                + phoneType + ", emailAddress=" + emailAddress + ", additionalProperties="
                + additionalProperties + "]";
    }

    /**
     * Builds a new {@link M5GBiAddress.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link M5GBiAddress.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .addressLine1(getAddressLine1())
                .city(getCity())
                .state(getState())
                .zip(getZip())
                .zip4(getZip4())
                .phone(getPhone())
                .phoneType(getPhoneType())
                .emailAddress(getEmailAddress());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link M5GBiAddress}.
     */
    public static class Builder {
        private String addressLine1;
        private String city;
        private String state;
        private String zip;
        private String zip4;
        private String phone;
        private String phoneType;
        private String emailAddress;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();



        /**
         * Setter for addressLine1.
         * @param  addressLine1  String value for addressLine1.
         * @return Builder
         */
        public Builder addressLine1(String addressLine1) {
            this.addressLine1 = addressLine1;
            return this;
        }

        /**
         * Setter for city.
         * @param  city  String value for city.
         * @return Builder
         */
        public Builder city(String city) {
            this.city = city;
            return this;
        }

        /**
         * Setter for state.
         * @param  state  String value for state.
         * @return Builder
         */
        public Builder state(String state) {
            this.state = state;
            return this;
        }

        /**
         * Setter for zip.
         * @param  zip  String value for zip.
         * @return Builder
         */
        public Builder zip(String zip) {
            this.zip = zip;
            return this;
        }

        /**
         * Setter for zip4.
         * @param  zip4  String value for zip4.
         * @return Builder
         */
        public Builder zip4(String zip4) {
            this.zip4 = zip4;
            return this;
        }

        /**
         * Setter for phone.
         * @param  phone  String value for phone.
         * @return Builder
         */
        public Builder phone(String phone) {
            this.phone = phone;
            return this;
        }

        /**
         * Setter for phoneType.
         * @param  phoneType  String value for phoneType.
         * @return Builder
         */
        public Builder phoneType(String phoneType) {
            this.phoneType = phoneType;
            return this;
        }

        /**
         * Setter for emailAddress.
         * @param  emailAddress  String value for emailAddress.
         * @return Builder
         */
        public Builder emailAddress(String emailAddress) {
            this.emailAddress = emailAddress;
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
         * Builds a new {@link M5GBiAddress} object using the set fields.
         * @return {@link M5GBiAddress}
         */
        public M5GBiAddress build() {
            M5GBiAddress model =
                    new M5GBiAddress(addressLine1, city, state, zip, zip4, phone, phoneType,
                            emailAddress);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
