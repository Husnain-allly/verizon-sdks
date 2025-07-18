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
import java.util.List;
import java.util.Map;

/**
 * This is a model class for RatePlanGroup type.
 */
public class RatePlanGroup {
    private String ratePlanGroupDescription;
    private Object ratePlanType;
    private List<Rateplantype2> ratePlan;
    private String description;
    private String sizeKb;
    private String carrierRatePlanCode;
    private Boolean zeroDollarBilling;
    private Boolean promotionOffered;
    private Integer promotionDays;
    private List<Accountid> account;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public RatePlanGroup() {
    }

    /**
     * Initialization constructor.
     * @param  ratePlanGroupDescription  String value for ratePlanGroupDescription.
     * @param  ratePlanType  Object value for ratePlanType.
     * @param  ratePlan  List of Rateplantype2 value for ratePlan.
     * @param  description  String value for description.
     * @param  sizeKb  String value for sizeKb.
     * @param  carrierRatePlanCode  String value for carrierRatePlanCode.
     * @param  zeroDollarBilling  Boolean value for zeroDollarBilling.
     * @param  promotionOffered  Boolean value for promotionOffered.
     * @param  promotionDays  Integer value for promotionDays.
     * @param  account  List of Accountid value for account.
     */
    public RatePlanGroup(
            String ratePlanGroupDescription,
            Object ratePlanType,
            List<Rateplantype2> ratePlan,
            String description,
            String sizeKb,
            String carrierRatePlanCode,
            Boolean zeroDollarBilling,
            Boolean promotionOffered,
            Integer promotionDays,
            List<Accountid> account) {
        this.ratePlanGroupDescription = ratePlanGroupDescription;
        this.ratePlanType = ratePlanType;
        this.ratePlan = ratePlan;
        this.description = description;
        this.sizeKb = sizeKb;
        this.carrierRatePlanCode = carrierRatePlanCode;
        this.zeroDollarBilling = zeroDollarBilling;
        this.promotionOffered = promotionOffered;
        this.promotionDays = promotionDays;
        this.account = account;
    }

    /**
     * Getter for RatePlanGroupDescription.
     * @return Returns the String
     */
    @JsonGetter("ratePlanGroupDescription")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getRatePlanGroupDescription() {
        return ratePlanGroupDescription;
    }

    /**
     * Setter for RatePlanGroupDescription.
     * @param ratePlanGroupDescription Value for String
     */
    @JsonSetter("ratePlanGroupDescription")
    public void setRatePlanGroupDescription(String ratePlanGroupDescription) {
        this.ratePlanGroupDescription = ratePlanGroupDescription;
    }

    /**
     * Getter for RatePlanType.
     * @return Returns the Object
     */
    @JsonGetter("ratePlanType")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public Object getRatePlanType() {
        return ratePlanType;
    }

    /**
     * Setter for RatePlanType.
     * @param ratePlanType Value for Object
     */
    @JsonSetter("ratePlanType")
    public void setRatePlanType(Object ratePlanType) {
        this.ratePlanType = ratePlanType;
    }

    /**
     * Getter for RatePlan.
     * An array of rateplan names
     * @return Returns the List of Rateplantype2
     */
    @JsonGetter("ratePlan")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<Rateplantype2> getRatePlan() {
        return ratePlan;
    }

    /**
     * Setter for RatePlan.
     * An array of rateplan names
     * @param ratePlan Value for List of Rateplantype2
     */
    @JsonSetter("ratePlan")
    public void setRatePlan(List<Rateplantype2> ratePlan) {
        this.ratePlan = ratePlan;
    }

    /**
     * Getter for Description.
     * @return Returns the String
     */
    @JsonGetter("description")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getDescription() {
        return description;
    }

    /**
     * Setter for Description.
     * @param description Value for String
     */
    @JsonSetter("description")
    public void setDescription(String description) {
        this.description = description;
    }

    /**
     * Getter for SizeKb.
     * @return Returns the String
     */
    @JsonGetter("sizeKb")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getSizeKb() {
        return sizeKb;
    }

    /**
     * Setter for SizeKb.
     * @param sizeKb Value for String
     */
    @JsonSetter("sizeKb")
    public void setSizeKb(String sizeKb) {
        this.sizeKb = sizeKb;
    }

    /**
     * Getter for CarrierRatePlanCode.
     * @return Returns the String
     */
    @JsonGetter("carrierRatePlanCode")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getCarrierRatePlanCode() {
        return carrierRatePlanCode;
    }

    /**
     * Setter for CarrierRatePlanCode.
     * @param carrierRatePlanCode Value for String
     */
    @JsonSetter("carrierRatePlanCode")
    public void setCarrierRatePlanCode(String carrierRatePlanCode) {
        this.carrierRatePlanCode = carrierRatePlanCode;
    }

    /**
     * Getter for ZeroDollarBilling.
     * @return Returns the Boolean
     */
    @JsonGetter("zeroDollarBilling")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public Boolean getZeroDollarBilling() {
        return zeroDollarBilling;
    }

    /**
     * Setter for ZeroDollarBilling.
     * @param zeroDollarBilling Value for Boolean
     */
    @JsonSetter("zeroDollarBilling")
    public void setZeroDollarBilling(Boolean zeroDollarBilling) {
        this.zeroDollarBilling = zeroDollarBilling;
    }

    /**
     * Getter for PromotionOffered.
     * @return Returns the Boolean
     */
    @JsonGetter("promotionOffered")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public Boolean getPromotionOffered() {
        return promotionOffered;
    }

    /**
     * Setter for PromotionOffered.
     * @param promotionOffered Value for Boolean
     */
    @JsonSetter("promotionOffered")
    public void setPromotionOffered(Boolean promotionOffered) {
        this.promotionOffered = promotionOffered;
    }

    /**
     * Getter for PromotionDays.
     * @return Returns the Integer
     */
    @JsonGetter("promotionDays")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public Integer getPromotionDays() {
        return promotionDays;
    }

    /**
     * Setter for PromotionDays.
     * @param promotionDays Value for Integer
     */
    @JsonSetter("promotionDays")
    public void setPromotionDays(Integer promotionDays) {
        this.promotionDays = promotionDays;
    }

    /**
     * Getter for Account.
     * Account information
     * @return Returns the List of Accountid
     */
    @JsonGetter("account")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<Accountid> getAccount() {
        return account;
    }

    /**
     * Setter for Account.
     * Account information
     * @param account Value for List of Accountid
     */
    @JsonSetter("account")
    public void setAccount(List<Accountid> account) {
        this.account = account;
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
     * Converts this RatePlanGroup into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "RatePlanGroup [" + "ratePlanGroupDescription=" + ratePlanGroupDescription
                + ", ratePlanType=" + ratePlanType + ", ratePlan=" + ratePlan + ", description="
                + description + ", sizeKb=" + sizeKb + ", carrierRatePlanCode="
                + carrierRatePlanCode + ", zeroDollarBilling=" + zeroDollarBilling
                + ", promotionOffered=" + promotionOffered + ", promotionDays=" + promotionDays
                + ", account=" + account + ", additionalProperties=" + additionalProperties + "]";
    }

    /**
     * Builds a new {@link RatePlanGroup.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link RatePlanGroup.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .ratePlanGroupDescription(getRatePlanGroupDescription())
                .ratePlanType(getRatePlanType())
                .ratePlan(getRatePlan())
                .description(getDescription())
                .sizeKb(getSizeKb())
                .carrierRatePlanCode(getCarrierRatePlanCode())
                .zeroDollarBilling(getZeroDollarBilling())
                .promotionOffered(getPromotionOffered())
                .promotionDays(getPromotionDays())
                .account(getAccount());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link RatePlanGroup}.
     */
    public static class Builder {
        private String ratePlanGroupDescription;
        private Object ratePlanType;
        private List<Rateplantype2> ratePlan;
        private String description;
        private String sizeKb;
        private String carrierRatePlanCode;
        private Boolean zeroDollarBilling;
        private Boolean promotionOffered;
        private Integer promotionDays;
        private List<Accountid> account;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();



        /**
         * Setter for ratePlanGroupDescription.
         * @param  ratePlanGroupDescription  String value for ratePlanGroupDescription.
         * @return Builder
         */
        public Builder ratePlanGroupDescription(String ratePlanGroupDescription) {
            this.ratePlanGroupDescription = ratePlanGroupDescription;
            return this;
        }

        /**
         * Setter for ratePlanType.
         * @param  ratePlanType  Object value for ratePlanType.
         * @return Builder
         */
        public Builder ratePlanType(Object ratePlanType) {
            this.ratePlanType = ratePlanType;
            return this;
        }

        /**
         * Setter for ratePlan.
         * @param  ratePlan  List of Rateplantype2 value for ratePlan.
         * @return Builder
         */
        public Builder ratePlan(List<Rateplantype2> ratePlan) {
            this.ratePlan = ratePlan;
            return this;
        }

        /**
         * Setter for description.
         * @param  description  String value for description.
         * @return Builder
         */
        public Builder description(String description) {
            this.description = description;
            return this;
        }

        /**
         * Setter for sizeKb.
         * @param  sizeKb  String value for sizeKb.
         * @return Builder
         */
        public Builder sizeKb(String sizeKb) {
            this.sizeKb = sizeKb;
            return this;
        }

        /**
         * Setter for carrierRatePlanCode.
         * @param  carrierRatePlanCode  String value for carrierRatePlanCode.
         * @return Builder
         */
        public Builder carrierRatePlanCode(String carrierRatePlanCode) {
            this.carrierRatePlanCode = carrierRatePlanCode;
            return this;
        }

        /**
         * Setter for zeroDollarBilling.
         * @param  zeroDollarBilling  Boolean value for zeroDollarBilling.
         * @return Builder
         */
        public Builder zeroDollarBilling(Boolean zeroDollarBilling) {
            this.zeroDollarBilling = zeroDollarBilling;
            return this;
        }

        /**
         * Setter for promotionOffered.
         * @param  promotionOffered  Boolean value for promotionOffered.
         * @return Builder
         */
        public Builder promotionOffered(Boolean promotionOffered) {
            this.promotionOffered = promotionOffered;
            return this;
        }

        /**
         * Setter for promotionDays.
         * @param  promotionDays  Integer value for promotionDays.
         * @return Builder
         */
        public Builder promotionDays(Integer promotionDays) {
            this.promotionDays = promotionDays;
            return this;
        }

        /**
         * Setter for account.
         * @param  account  List of Accountid value for account.
         * @return Builder
         */
        public Builder account(List<Accountid> account) {
            this.account = account;
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
         * Builds a new {@link RatePlanGroup} object using the set fields.
         * @return {@link RatePlanGroup}
         */
        public RatePlanGroup build() {
            RatePlanGroup model =
                    new RatePlanGroup(ratePlanGroupDescription, ratePlanType, ratePlan, description,
                            sizeKb, carrierRatePlanCode, zeroDollarBilling, promotionOffered,
                            promotionDays, account);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
