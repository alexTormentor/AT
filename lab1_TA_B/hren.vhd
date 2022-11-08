library IEEE; 
use IEEE.STD_LOGIC_1164.ALL; 
use IEEE.STD_LOGIC_ARITH.ALL; 
USE IEEE.STD_LOGIC_UNSIGNED.ALL; 
entity hren is generic (n:integer:=4); -- n ��������, ������ ����������� ��������� 
Port(a:in std_logic_vector(n-1 downto 0); -- �������� 
	 b: in std_logic_vector(n-1 downto 0); -- ��������� 
	 c: out std_logic_vector(2*n-1 downto 0)); -- ������������ 
end hren; 
architecture Behavioral of hren is 
begin process(a,b) 
variable rb: std_logic_vector (n-1 downto 0); -- ��� �������� ��������� 
variable ra: std_logic_vector (2*n-1 downto 0);-- ��� �������� ���������
variable rc: std_logic_vector(2*n-1 downto 0); -- ��� ������������ ����� �� 
begin 
ra(n-1 downto 0):=a; -- ����������� ra �������� ��������� 
ra(2*n-1 downto n):=(others =>a(n-1)); -- ��������� ������� ������� ra �������� 
rb:=b; -- ����������� rb �������� ��������� 
rc:=(others=>'0'); -- ������� ����� �� 
for i in 1 to n loop -- ��������� � ����� n ��� 
	if (rb(n-1)='1') then 
		if i=1 then 
			rc:= rc+not(ra)+1; -- �������������� ���[-A]� 
			else rc:= rc+ra; -- ���������� �������� +[A]� 
		end if; 
	end if; 
		if i=n then exit; -- ���� ��������� ���, �� ������� �� ����� 
	end if; 
	rc(2*n-1 downto 0):=rc(2*n-2 downto 0)&'0'; -- ���� ����� �� ����� 
	rb:=rb(n-2 downto 0)&'0'; -- ����� ��������� ����� 
end loop; 
c<=rc(2*n-1 downto 0); -- �������� ���������� �� ����� ���������� 
end process; 
end Behavioral;