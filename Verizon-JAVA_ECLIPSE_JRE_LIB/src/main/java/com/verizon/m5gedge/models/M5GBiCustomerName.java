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
 * This is a model class for M5GBiCustomerName type.
 */
public class M5GBiCustomerName {
    private String firstName;
    private String lastName;
    private String middleName;
    private String title;
    private String suffex;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public M5GBiCustomerName() {
    }

    /**
     * Initialization constructor.
     * @param  firstName  String value for firstName.
     * @param  lastName  String value for lastName.
     * @param  middleName  String value for middleName.
     * @param  title  String value for title.
     * @param  suffex  String value for suffex.
     */
    public M5GBiCustomerName(
            String firstName,
            String lastName,
            String middleName,
            String title,
            String suffex) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.middleName = middleName;
        this.title = title;
        this.suffex = suffex;
    }

    /**
     * Getter for FirstName.
     * @return Returns the String
     */
    @JsonGetter("firstName")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getFirstName() {
        return firstName;
    }

    /**
     * Setter for FirstName.
     * @param firstName Value for String
     */
    @JsonSetter("firstName")
    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    /**
     * Getter for LastName.
     * @return Returns the String
     */
    @JsonGetter("lastName")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getLastName() {
        return lastName;
    }

    /**
     * Setter for LastName.
     * @param lastName Value for String
     */
    @JsonSetter("lastName")
    public void setLastName(String lastName) {
        this.lastName = lastName;
    }

    /**
     * Getter for MiddleName.
     * @return Returns the String
     */
    @JsonGetter("middleName")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getMiddleName() {
        return middleName;
    }

    /**
     * Setter for MiddleName.
     * @param middleName Value for String
     */
    @JsonSetter("middleName")
    public void setMiddleName(String middleName) {
        this.middleName = middleName;
    }

    /**
     * Getter for Title.
     * @return Returns the String
     */
    @JsonGetter("title")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getTitle() {
        return title;
    }

    /**
     * Setter for Title.
     * @param title Value for String
     */
    @JsonSetter("title")
    public void setTitle(String title) {
        this.title = title;
    }

    /**
     * Getter for Suffex.
     * @return Returns the String
     */
    @JsonGetter("suffex")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getSuffex() {
        return suffex;
    }

    /**
     * Setter for Suffex.
     * @param suffex Value for String
     */
    @JsonSetter("suffex")
    public void setSuffex(String suffex) {
        this.suffex = suffex;
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
     * Converts this M5GBiCustomerName into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "M5GBiCustomerName [" + "firstName=" + firstName + ", lastName=" + lastName
                + ", middleName=" + middleName + ", title=" + title + ", suffex=" + suffex
                + ", additionalProperties=" + additionalProperties + "]";
    }

    /**
     * Builds a new {@link M5GBiCustomerName.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link M5GBiCustomerName.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .firstName(getFirstName())
                .lastName(getLastName())
                .middleName(getMiddleName())
                .title(getTitle())
                .suffex(getSuffex());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link M5GBiCustomerName}.
     */
    public static class Builder {
        private String firstName;
        private String lastName;
        private String middleName;
        private String title;
        private String suffex;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();



        /**
         * Setter for firstName.
         * @param  firstName  String value for firstName.
         * @return Builder
         */
        public Builder firstName(String firstName) {
            this.firstName = firstName;
            return this;
        }

        /**
         * Setter for lastName.
         * @param  lastName  String value for lastName.
         * @return Builder
         */
        public Builder lastName(String lastName) {
            this.lastName = lastName;
            return this;
        }

        /**
         * Setter for middleName.
         * @param  middleName  String value for middleName.
         * @return Builder
         */
        public Builder middleName(String middleName) {
            this.middleName = middleName;
            return this;
        }

        /**
         * Setter for title.
         * @param  title  String value for title.
         * @return Builder
         */
        public Builder title(String title) {
            this.title = title;
            return this;
        }

        /**
         * Setter for suffex.
         * @param  suffex  String value for suffex.
         * @return Builder
         */
        public Builder suffex(String suffex) {
            this.suffex = suffex;
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
         * Builds a new {@link M5GBiCustomerName} object using the set fields.
         * @return {@link M5GBiCustomerName}
         */
        public M5GBiCustomerName build() {
            M5GBiCustomerName model =
                    new M5GBiCustomerName(firstName, lastName, middleName, title, suffex);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
