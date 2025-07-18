/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.models;

import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonSetter;

/**
 * This is a model class for DtoUpdateUserRequest type.
 */
public class DtoUpdateUserRequest {
    private String accountname;
    private String id;
    private DtoUserDto user;

    /**
     * Default constructor.
     */
    public DtoUpdateUserRequest() {
    }

    /**
     * Initialization constructor.
     * @param  accountname  String value for accountname.
     * @param  id  String value for id.
     * @param  user  DtoUserDto value for user.
     */
    public DtoUpdateUserRequest(
            String accountname,
            String id,
            DtoUserDto user) {
        this.accountname = accountname;
        this.id = id;
        this.user = user;
    }

    /**
     * Getter for Accountname.
     * The numeric account name, which must include leading zeros
     * @return Returns the String
     */
    @JsonGetter("accountname")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getAccountname() {
        return accountname;
    }

    /**
     * Setter for Accountname.
     * The numeric account name, which must include leading zeros
     * @param accountname Value for String
     */
    @JsonSetter("accountname")
    public void setAccountname(String accountname) {
        this.accountname = accountname;
    }

    /**
     * Getter for Id.
     * UUID of the user record, assigned at creation
     * @return Returns the String
     */
    @JsonGetter("id")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getId() {
        return id;
    }

    /**
     * Setter for Id.
     * UUID of the user record, assigned at creation
     * @param id Value for String
     */
    @JsonSetter("id")
    public void setId(String id) {
        this.id = id;
    }

    /**
     * Getter for User.
     * @return Returns the DtoUserDto
     */
    @JsonGetter("user")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public DtoUserDto getUser() {
        return user;
    }

    /**
     * Setter for User.
     * @param user Value for DtoUserDto
     */
    @JsonSetter("user")
    public void setUser(DtoUserDto user) {
        this.user = user;
    }

    /**
     * Converts this DtoUpdateUserRequest into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "DtoUpdateUserRequest [" + "accountname=" + accountname + ", id=" + id + ", user="
                + user + "]";
    }

    /**
     * Builds a new {@link DtoUpdateUserRequest.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link DtoUpdateUserRequest.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .accountname(getAccountname())
                .id(getId())
                .user(getUser());
        return builder;
    }

    /**
     * Class to build instances of {@link DtoUpdateUserRequest}.
     */
    public static class Builder {
        private String accountname;
        private String id;
        private DtoUserDto user;



        /**
         * Setter for accountname.
         * @param  accountname  String value for accountname.
         * @return Builder
         */
        public Builder accountname(String accountname) {
            this.accountname = accountname;
            return this;
        }

        /**
         * Setter for id.
         * @param  id  String value for id.
         * @return Builder
         */
        public Builder id(String id) {
            this.id = id;
            return this;
        }

        /**
         * Setter for user.
         * @param  user  DtoUserDto value for user.
         * @return Builder
         */
        public Builder user(DtoUserDto user) {
            this.user = user;
            return this;
        }

        /**
         * Builds a new {@link DtoUpdateUserRequest} object using the set fields.
         * @return {@link DtoUpdateUserRequest}
         */
        public DtoUpdateUserRequest build() {
            return new DtoUpdateUserRequest(accountname, id, user);
        }
    }
}
