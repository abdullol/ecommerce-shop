export interface Data {
	id: number;
	name: string;
	description: string;
	price: number;
	pictureUrl: string;
	productType: string;
	productBrand: string;
}

import {IProduct}from './product'
export interface IPagination {
	pageIndex: number;
	pageSize: number;
	count: number;
	data: IProduct[];
}